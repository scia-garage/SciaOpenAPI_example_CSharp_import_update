using SCIA.OpenAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SciaOpenAPI_example_cs_import_update
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyAppPath = AppDomain.CurrentDomain.BaseDirectory;
            SCIA.OpenAPI.Environment env = new SCIA.OpenAPI.Environment(@"c:\scia\git\sen\a\bin\release32", @".\temp");
            env.RunSCIAEngineer(SCIA.OpenAPI.Environment.GuiMode.ShowWindowShow);
            
            SCIA.OpenAPI.EsaProject UpXmlProj = env.OpenProject(System.IO.Path.Combine(MyAppPath, @"..\..\..\res\template.esa"));
            env.UpdateProject(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeXML, System.IO.Path.Combine(MyAppPath, @"..\..\..\res\xml\test.xml"), UpXmlProj.ProjectID);
            UpXmlProj.CloseProject(SaveMode.SaveChangesNo);
            
            SCIA.OpenAPI.EsaProject UpEsaProj = env.OpenProject(System.IO.Path.Combine(MyAppPath, @"..\..\..\res\template.esa"));
            env.UpdateProject(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeESA, System.IO.Path.Combine(MyAppPath, @"..\..\..\res\esa\test.esa"), UpEsaProj.ProjectID);
            UpEsaProj.CloseProject(SaveMode.SaveChangesNo);

            SCIA.OpenAPI.EsaProject UpIfcProj = env.OpenProject(System.IO.Path.Combine(MyAppPath, @"..\..\..\res\template.esa"));
            env.UpdateProject(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeIFC, System.IO.Path.Combine(MyAppPath, @"..\..\..\res\ifc\test.ifc"), UpIfcProj.ProjectID);
            UpIfcProj.CloseProject(SaveMode.SaveChangesNo);
            
            SCIA.OpenAPI.EsaProject UpRevitProj = env.OpenProject(System.IO.Path.Combine(MyAppPath, @"..\..\..\res\template.esa"));
            env.UpdateProject(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeRevit, System.IO.Path.Combine(MyAppPath, @"..\..\..\res\revit\test.r2s"), UpRevitProj.ProjectID);
            UpRevitProj.CloseProject(SaveMode.SaveChangesNo);
            
            SCIA.OpenAPI.EsaProject UpTeklaProj = env.OpenProject(System.IO.Path.Combine(MyAppPath, @"..\..\..\res\template.esa"));
            env.UpdateProject(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeTekla, System.IO.Path.Combine(MyAppPath, @"..\..\..\res\tekla\test.t2s"),UpTeklaProj.ProjectID);
            UpTeklaProj.CloseProject(SaveMode.SaveChangesNo);
            
            SCIA.OpenAPI.EsaProject UpXlsxProj = env.OpenProject(System.IO.Path.Combine(MyAppPath, @"..\..\..\res\template.esa"));
            env.UpdateProject(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeAEF, System.IO.Path.Combine(MyAppPath, @"..\..\..\res\aef\test.xlsx"), UpXlsxProj.ProjectID);
            UpXlsxProj.CloseProject(SaveMode.SaveChangesNo);
            
            //==========================================================
            Guid newXmlproject;
            //Guid newEsaproject;
            Guid newIfcproject;
            Guid newRevitproject;
            Guid newTeklaproject;
            Guid newAefproject;

            EsaProject ImXmlpProj = env.ImportProjectFromFile(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeXML, System.IO.Path.Combine(MyAppPath, @"..\..\..\res\xml\test.xml"), out newXmlproject);
            //ESA project cannot be "imported" into SEn...just opened //EsaProject ImpEsaProj = env.ImportProjectFromFile(System.IO.Path.Combine(MyAppPath, @"..\..\..\res\esa\test.esa"), out newEsaproject);
            EsaProject ImpIfcProj = env.ImportProjectFromFile(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeIFC, System.IO.Path.Combine(MyAppPath, @"..\..\..\res\ifc\test.ifc"), out newIfcproject);
            EsaProject ImpRevitProj = env.ImportProjectFromFile(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeRevit, System.IO.Path.Combine(MyAppPath, @"..\..\..\res\revit\test.r2s"), out newRevitproject);
            EsaProject ImpTeklaProj = env.ImportProjectFromFile(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeTekla, System.IO.Path.Combine(MyAppPath, @"..\..\..\res\tekla\test.t2s"), out newTeklaproject);
            EsaProject ImpAefProj = env.ImportProjectFromFile(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeAEF, System.IO.Path.Combine(MyAppPath, @"..\..\..\res\aef\test.xlsx"), out newAefproject);

            env.CloseAllProjects(SaveMode.SaveChangesNo);
            
        }
    }
}
