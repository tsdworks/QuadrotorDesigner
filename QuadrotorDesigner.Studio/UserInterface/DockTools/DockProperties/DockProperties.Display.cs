﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Controls;
using DarkUI.Docking;
using QuadrotorDesigner.Utils.IOStream;
using QuadrotorDesigner.Utils.Notation;
using QuadrotorDesigner.Workspace.Properties;

namespace QuadrotorDesigner.Workspace.UserInterface.DockTools
{
    public partial class DockProperties : DarkToolWindow
    {
        public void DisplayShowDetail(DocumentManager.ComponentDocument currentDocument)
        {
            var componentBaseModel = OStream.GetStreamObject<Components.Model.Base>(currentDocument.JSONText);

            labelType.Text = "Type : " + componentBaseModel.ModelType.ToString();
            labelDispalyName.Text = "Dispaly Name : " + componentBaseModel.DisplayName.ToString();
            labelManufacturer.Text = "Manufacturer : " + componentBaseModel.Manufacturer.ToString();
            labelModel.Text = "Model : " + componentBaseModel.Model.ToString();
            labelUnitPrice.Text = "Unit Price : " + componentBaseModel.UnitPrice.ToString();
            labelReliability.Text = "Reliability : " + componentBaseModel.Reliability.ToString();
            labelWeight.Text = "Weight : " + componentBaseModel.Weight.ToString();
            labelOutlineDimensionX.Text = "Outline Length : " + componentBaseModel.OutlineDimension.Length.ToString();
            labelOutlineDimensionY.Text = "Outline Width : " + componentBaseModel.OutlineDimension.Width.ToString();
            labelOutlineDimensionZ.Text = "Outline Height : " + componentBaseModel.OutlineDimension.Height.ToString();

            string previewImageFileName = currentDocument.FilePath.Replace(Resources.ModelFileExtName, ".jpg");

            if (File.Exists(previewImageFileName))
            {
                pictureBoxImagePreview.Image = Bitmap.FromFile(previewImageFileName);
            }
            else
            {
                pictureBoxImagePreview.Image = null;
            }
        }
    }
}
