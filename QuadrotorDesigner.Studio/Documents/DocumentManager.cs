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
using QuadrotorDesigner.Workspace.UserInterface.DockTools;
using static QuadrotorDesigner.Workspace.Designer.DesignEngine;

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
            public bool Disable;

            public Model.ModelTypeList ModelType;
            public Image DoucumentIcon;

            public string JSONText;

            public DockDocument DockDocument;

            public RelationDesigner DroneDesigner;

            public ComponentDocument(string filePath = "", string modelFileName = "", string jsonText = "",
                Model.ModelTypeList modelType = Model.ModelTypeList.None, bool fileEditable = false, bool selectState = false)
            {
                ModelFileName = modelFileName;
                FilePath = filePath;
                JSONText = jsonText;
                ModelType = modelType;
                Editable = fileEditable;
                Selected = selectState;
                Disable = false;

                ModelFileWindowTitle = 
                    (Editable ? Resources.TitleEditable : Resources.TitleReadonly) + ModelFileName;

                DoucumentIcon = ModelType == Model.ModelTypeList.Assembly ? Resources.design_icon : Resources.component_file;

                DockDocument = new DockDocument(this);

                DroneDesigner = null;
            }

            public void UpdateWindowTitle()
            {
                ModelFileWindowTitle = 
                    (Editable ? ((Unsaved ? "*" : string.Empty) + Resources.TitleEditable) : Resources.TitleReadonly) + ModelFileName;

                DockDocument.DockText = ModelFileWindowTitle;

                DockDocument.Refresh();
            }

            public void AssemblyUpdateEditor()
            {
                if (DroneDesigner != null)
                {
                    JSONText = DroneDesigner.GetDesignProjectJSON();
                    DockDocument.SetEditorContent(JSONText);
                    DockDocument.SetEditorReadonly(Editable);
                    FStream.WriteStreamToTextFile(FilePath, JSONText);
                }
            }
        }

        static public List<ComponentDocument> LocalModelDocuments = new List<ComponentDocument>();
        static public ComponentDocument CurrentModelDocument = null;
        static public ComponentDocument CurrentSelectedModelNode = null;
        static public ComponentDocument CurrentAssembly = null;

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

        public static void NewAssembly(string Name, string Author, string Description, string FileName, string FilePath)
        {
            CurrentAssembly = new ComponentDocument(FilePath, FileName, string.Empty, Model.ModelTypeList.Assembly, false, false);
            CurrentAssembly.DroneDesigner = new RelationDesigner(Name, Author, Description, LocalModelDocuments);
        }
    }
}
