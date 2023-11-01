using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIKitTutorials
{
    public static class Anticheat
    {
        private static bool isTriggered = false;

        public static void Check(string directoryPath)
        {
            isTriggered = false;
            string[] files = Directory.GetFiles(directoryPath);

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                if (!WhitelistedFiles.Contains(fileName))
                {
                    isTriggered = true;
                    break;
                }
            }

            if (isTriggered)
            {
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(
                "Mon reuf, tu n'essayerais pas de cheat?",
                "GalaxiaAntiCheat",
                MessageBoxButtons.OK);
            }
        }

        public static bool IsTriggered
        {
            get { return isTriggered; }
        }

        private static readonly string[] WhitelistedFiles = new string[]
        {
    "pakchunk0_s1-WindowsClient.pak",
    "pakchunk0_s2-WindowsClient.pak",
    "pakchunk0_s3-WindowsClient.pak",
    "pakchunk0_s4-WindowsClient.pak",
    "pakchunk0_s5-WindowsClient.pak",
    "pakchunk0_s6-WindowsClient.pak",
    "pakchunk0_s7-WindowsClient.pak",
    "pakchunk0-WindowsClient.pak",
    "pakchunk1_s1-WindowsClient.pak",
    "pakchunk1-WindowsClient.pak",
    "pakchunk2-WindowsClient.pak",
    "pakchunk5-WindowsClient.pak",
    "pakchunk7-WindowsClient.pak",
    "pakchunk8-WindowsClient.pak",
    "pakchunk9-WindowsClient.pak",
    "pakchunk15-WindowsClient.pak",
    "pakchunk1000-WindowsClient.pak",
    "pakchunk1001-WindowsClient.pak",
    "pakchunk1002-WindowsClient.pak",
    "pakchunk1003-WindowsClient.pak",
    "pakchunk1004-WindowsClient.pak",
    "pakchunkMCBuilds-WindowsClient.pak",
    "pakchunk0_s1-WindowsClient.sig",
    "pakchunk0_s2-WindowsClient.sig",
    "pakchunk0_s3-WindowsClient.sig",
    "pakchunk0_s4-WindowsClient.sig",
    "pakchunk0_s5-WindowsClient.sig",
    "pakchunk0_s6-WindowsClient.sig",
    "pakchunk0_s7-WindowsClient.sig",
    "pakchunk0-WindowsClient.sig",
    "pakchunk1_s1-WindowsClient.sig",
    "pakchunk1-WindowsClient.sig",
    "pakchunk2-WindowsClient.sig",
    "pakchunk5-WindowsClient.sig",
    "pakchunk7-WindowsClient.sig",
    "pakchunk8-WindowsClient.sig",
    "pakchunk9-WindowsClient.sig",
    "pakchunk15-WindowsClient.sig",
    "pakchunk1000-WindowsClient.sig",
    "pakchunk1001-WindowsClient.sig",
    "pakchunk1002-WindowsClient.sig",
    "pakchunk1003-WindowsClient.sig",
    "pakchunk1004-WindowsClient.sig",
    "pakchunkMCBuilds-WindowsClient.sig"
        };
    }
}