using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class FileOpr
{
    public string ImageFileOpen()
    {
        var ofd = new OpenFileDialog();
        ofd.Filter = "Image File(*.bmp,*.jpg,*.png,*.tif)|*.bmp;*.jpg;*.png;*.tif|Bitmap(*.bmp)|*.bmp|Jpeg(*.jpg)|*.jpg|PNG(*.png)|*.png";
        if (ofd.ShowDialog() == DialogResult.Cancel) return null;

        if (System.IO.File.Exists(ofd.FileName) == false) return null;
        // check extention
        var ext = System.IO.Path.GetExtension(ofd.FileName).ToLower();

        if (
            (ext != ".bmp") &&
            (ext != ".jpg") &&
            (ext != ".png") &&
            (ext != ".tif")
            )
        {
            return null;
        }

        return ofd.FileName;
    }

    public string CSVFileOpen()
    {
        var ofd = new OpenFileDialog();
        ofd.Filter = "CSV File(*.csv)|*.csv";
        if (ofd.ShowDialog() == DialogResult.Cancel) return null;

        if (System.IO.File.Exists(ofd.FileName) == false) return null;
        // check extention
        var ext = System.IO.Path.GetExtension(ofd.FileName).ToLower();

        return ofd.FileName;
    }

    public string WorkFolderOpen()
    {
        using (var cofd = new CommonOpenFileDialog()
        {
            Title = "Select Folder",
            InitialDirectory = @"D:\",
            IsFolderPicker = true,
        })
        {
            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return cofd.FileName;
            }
        }
        return String.Empty;
    }

}
