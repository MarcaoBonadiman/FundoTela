using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundoTela
{
    internal class cFuncoes
    {
        public static void LerDir(String path, String ext,ref int ponteiro,ref FileInfo[]? filesInfo)
        {
            int old_pon = ponteiro;
            var filePath = Environment.ExpandEnvironmentVariables(path);
            DirectoryInfo d = new DirectoryInfo(filePath);   
            filesInfo = d.GetFiles(ext); //Getting Text files
            if (filesInfo.Length > 0)
            {
                if (old_pon != 0 && old_pon <= (filesInfo.Length - 1))
                {
                    ponteiro = old_pon;
                }
            }
            else
            {
                ponteiro = -1;
            }
        }
    }
}
