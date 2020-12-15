using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovative
{
    class ftp
    {
        public static void ListZip(string zipPath, ref ListView FilesList)
        {
            try
            {
                if (File.Exists(zipPath+ ".zip"))
                {
                    using (ZipFile zip = ZipFile.Read(zipPath + ".zip"))
                    {
                        FilesList.Items.Clear();
                        foreach (var file in zip.Entries)
                        {
                            FilesList.Items.Add(file.FileName);
                            FilesList.Items[FilesList.Items.Count - 1].Group = FilesList.Groups[1];
                            FilesList.Items[FilesList.Items.Count - 1].ImageIndex = 2;
                        }
                    }
                }
            }
            catch
            {
                new MBform("Не удалось отобразить файлы из локального хранилища.");
            }
        }
        public List<string> FTPListDirectoryDetails(string ServerInternal, string LoginInternal, string PasswordInternal)
        {
            try
            {
                List<string> ListDirectoryDetails = new List<string>();
                var ftp = (FtpWebRequest)FtpWebRequest.Create(ServerInternal + @"/");
                ftp.Credentials = new NetworkCredential(LoginInternal, PasswordInternal);
                ftp.KeepAlive = false;
                ftp.UseBinary = true;
                ftp.Proxy = null;
                ftp.Method = WebRequestMethods.Ftp.ListDirectory;
                var response = (FtpWebResponse)ftp.GetResponse();
                var responseStream = response.GetResponseStream();
                var reader = new StreamReader(responseStream);
                while (!reader.EndOfStream)
                {
                    ListDirectoryDetails.Add(reader.ReadLine());
                }
                if (ListDirectoryDetails.Count != 0)
                    ListDirectoryDetails.RemoveRange(0, 2);
                responseStream.Close();
                response.Close();
                reader.Close();
                return ListDirectoryDetails;
            }
            catch
            {
                new MBform("неполучилось");
                List<string> ListDirectoryDetails = new List<string>();
                return ListDirectoryDetails;
            }
        }
        public static void UploadFileToFtp(string login)
        {
            try
            {
                OpenFileDialog manager = new OpenFileDialog();
                manager.ShowDialog();
                var fileName = Path.GetFileName(manager.FileName);
                var request = (FtpWebRequest)WebRequest.Create("ftp://files.000webhost.com/" + login + "/" + fileName);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("innovative", "supersitepass");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;

                using (var fileStream = File.OpenRead(manager.FileName))
                {
                    using (var requestStream = request.GetRequestStream())
                    {
                        fileStream.CopyTo(requestStream);
                        requestStream.Close();
                    }
                }
                var response = (FtpWebResponse)request.GetResponse();
                response.Close();
            }
            catch (Exception)
            {
                //.Show("не удалось выгрузить файл");
            }
        }
        public static void LoadOnZip(string zipPath)
        {
            OpenFileDialog manager = new OpenFileDialog();
            manager.ShowDialog();
            ZipFile zipf = ZipFile.Read(zipPath + ".zip");
            try
            {
                zipf.Password = "1111";
                zipf.AddFile(manager.FileName, "");
                zipf.Save();
            }
            catch (Exception e)
            {
                new MBform(e.Message, "не удалось архивировать файл");
                return;
            }

        }
        public static void createZip(string zipPath)
        {
            if (!File.Exists(zipPath + ".zip"))
            {
                using (ZipFile zip = new ZipFile())
                {
                    zip.Password = "1111";
                    new MBform(zipPath + ".zip");
                    zip.Save(zipPath + ".zip");
                }
            }
        }
    }
}
