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
            public string FilePath;
            public string ModelFileWindowTitle;
            public bool Unsaved;
            public bool Editable;
            public bool Selected;
            public Model.ModelTypeList ModelType;
            public Image DoucumentIcon;
            public string JSONText;

            public UserInterface.DockTools.DockDocument DockDocument;

            public ComponentDocument(string filePath = "", string modelFileName = "", string jsonText = "",
                Model.ModelTypeList modelType = Model.ModelTypeList.None, bool fileEditable = false, bool selectState = false)
            {
                ModelFileName = modelFileName;
                FilePath = filePath;
                JSONText = jsonText;
                ModelType = modelType;
                Editable = fileEditable;
                Selected = selectState;

                ModelFileWindowTitle = 
                    (Editable ? Resources.TitleEditable : Resources.TitleReadonly) + ModelFileName;

                DoucumentIcon = ModelType == Model.ModelTypeList.Assembly ? Resources.design_icon : Resources.component_file;

                DockDocument = new UserInterface.DockTools.DockDocument(ModelFileWindowTitle, jsonText, DoucumentIcon);
            }

            public void UpdateWindowTitle()
            {
                ModelFileWindowTitle = 
                    (Editable ? ((Unsaved ? "*" : string.Empty) + Resources.TitleEditable) : Resources.TitleReadonly) + ModelFileName;

                DockDocument.DockText = ModelFileWindowTitle;

                DockDocument.Refresh();
            }
        }

        static public List<ComponentDocument> LocalModelDocuments = new List<ComponentDocument>();
        static public ComponentDocument CurrentModelDocument = null;

        public static List<ComponentDocument> LoadModelDocuments(string folderName, string extName, Model.ModelTypeList modelType)
        {
            List<ComponentDocument> retValue = new List<ComponentDocument>();

            try
            {
                List<FileInfo> fileInfo = FStream.GetAllFileInfo(folderName, extName);

                foreach(FileInfo currentFile in fileInfo)
                {
                    ComponentDocument currentDocument = new ComponentDocument(currentFile.FullName, currentFile.Name,
                        FStream.ReadStreamFromTextFile(currentFile.FullName), modelType);

                    retValue.Add(currentDocument);
                }
            }
            catch (Exception) { };

            return retValue;
        }

        public static void SetCurrentModelDocument(ComponentDocument currentDocument)
        {
            CurrentModelDocument = currentDocument;
        }

    }
}
