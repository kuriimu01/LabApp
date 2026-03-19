using LabApp.Security;
using LabApp.TBD_But;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabApp.Services
{
    public static class FileService
    {
        private const string AccessDeniedMessage = "Access Denied!";

        public static void Open(UserModel user, ResourceModel resource)
        {
            string path = resource.FilePath;
            string ext = Path.GetExtension(path).ToLower();

            bool canRead = AccessManager.CheckAccess(user, resource, "read");
            bool canWrite = AccessManager.CheckAccess(user, resource, "write");
            bool canExecute = AccessManager.CheckAccess(user, resource, "execute");

            switch (ext)
            {
                case ".png":
                case ".jpg":
                case ".jpeg":
                    OpenImage(path, canRead, canWrite);
                    break;
                case ".txt":
                    OpenText(path, canRead, canWrite);
                    break;
                case ".exe":
                    OpenExecutable(path, canExecute);
                    break;
                default:
                    OpenDefault(path, canRead);
                    break;
            }
        }

        private static void OpenImage(string path, bool canRead, bool canWrite)
        {
            if (canWrite)
            {
                Process.Start("mspaint.exe", path);
            }
            else if (canRead)
            {
                Process.Start(new ProcessStartInfo { FileName = path, UseShellExecute = true });
            }
            else
            {
                MessageBox.Show(AccessDeniedMessage);
            }
        }

        private static void OpenText(string path, bool canRead, bool canWrite)
        {
            if (canWrite)
            {
                Process.Start(new ProcessStartInfo { FileName = path, UseShellExecute = true });
            }
            else if (canRead)
            {
                string content = File.ReadAllText(path);
                MessageBox.Show(content, "File Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(AccessDeniedMessage);
            }
        }

        private static void OpenExecutable(string path, bool canExecute)
        {
            if (canExecute)
            {
                Process.Start(new ProcessStartInfo { FileName = path, UseShellExecute = true });
            }
            else
            {
                MessageBox.Show(AccessDeniedMessage);
            }
        }

        private static void OpenDefault(string path, bool canRead)
        {
            if (canRead)
            {
                Process.Start(new ProcessStartInfo { FileName = path, UseShellExecute = true });
            }
            else
            {
                MessageBox.Show(AccessDeniedMessage);
            }
        }
    }
}
