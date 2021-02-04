using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuadrotorDesigner.Components;
using QuadrotorDesigner.Workspace.Properties;
using QuadrotorDesigner.Utils.Notation;
using System.IO;
using QuadrotorDesigner.Utils.IOStream;

namespace QuadrotorDesigner.Workspace
{
    public class DocumentManager
    {
        public class ComponentDocument
        {
            public string ModelFileName;
            public string ModelFileWindowTitle;
            public bool Unsaved;
            public bool Editable;
            public Model.ModelTypeList ModelType;
            public Image DoucumentIcon;
            public string JSONText;

            public ComponentDocument(string modelfilename = "", string jsontext = "",
                Model.ModelTypeList modeltype = Model.ModelTypeList.None, bool editable = false)
            {
                JSONText = jsontext;
                Editable = editable;
                ModelFileName = modelfilename;
                ModelType = modeltype;
                ModelFileWindowTitle = 
                    (Editable ? Resources.TitleEditable : Resources.TitleReadonly) + ModelFileName;
                DoucumentIcon = ModelType == Model.ModelTypeList.Assembly ? Resources.design_icon : Resources.component_file;
            }

            public string GetCurrentWindowTitle()
            {
                ModelFileWindowTitle = 
                    (Editable ? ((Unsaved ? "*" : string.Empty) + Resources.TitleEditable) : Resources.TitleReadonly) + ModelFileName;

                return ModelFileWindowTitle;
            }
        }

        static public List<ComponentDocument> LocalModelDocuments = new List<ComponentDocument>();

        public static List<ComponentDocument> LoadModelDocuments(string folderName, string extName)
        {
            List<ComponentDocument> retValue = new List<ComponentDocument>();

            try
            {
                List<FileInfo> fileInfo = FStream.GetAllFileInfo(folderName, extName);

                foreach(FileInfo file in fileInfo)
                {
                    ComponentDocument document = new ComponentDocument(file.DirectoryName,
                        FStream.ReadStreamFromTextFile(file.DirectoryName));

                    retValue.Add(document);
                }
            }
            catch (Exception) { };

            return retValue;
        }

    }
}
