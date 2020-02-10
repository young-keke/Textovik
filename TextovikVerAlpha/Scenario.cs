using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Reflection;
using System.IO;

namespace TextovikVerAlpha
{
    class Scenario
    {
        public void Save()
        { }
    }
    class Scene
    {

    }
    class ImageEditor
    {
        public List<Image> Images { get; set; }
        public void AddImage(string pathToFile, string pathToSave)
        {
            if (pathToFile != null)
            {
                File.Copy(pathToFile, pathToSave);
            }
            else { }
            
        }
        public void AddImage(string[] pathToFiles, string pathToSave)
        {
            if (pathToFiles != null)
            {
                foreach (string path in pathToFiles)
                {
                    File.Copy(path, pathToSave);
                }
            }
        }
        public void DeleteImage(Image img)
        {
            Images.Remove(img);
        }

    }
    class AudioEditor
    {

    }
    class TextEditor
    {

    }
}
