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
            SCIA.OpenAPI.Environment env = new SCIA.OpenAPI.Environment(@"c:\scia\git\sen\a\bin\release32", @".\temp");
            env.RunSCIAEngineer(EnvESA80.TEnvESAApp_ShowWindow.eEPShowWindowShow);
            
            SCIA.OpenAPI.EsaProject UpXmlProj = env.OpenProject(@"c:\SCIA\GIThub\SciaOpenAPI_example_CSS.mat\res\empty.with.mat.lib.esa");
            env.UpdateProject(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeXML, @"c:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\xml\test.xml", UpXmlProj.ProjectID);
            UpXmlProj.CloseProject(EnvESA80.TEnvESAApp_SaveChanges.eEPSaveChangesNo);

            SCIA.OpenAPI.EsaProject UpEsaProj = env.OpenProject(@"c:\SCIA\GIThub\SciaOpenAPI_example_CSS.mat\res\empty.with.mat.lib.esa");
            env.UpdateProject(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeESA, @"c:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\esa\test.esa", UpEsaProj.ProjectID);
            UpEsaProj.CloseProject(EnvESA80.TEnvESAApp_SaveChanges.eEPSaveChangesNo);

            SCIA.OpenAPI.EsaProject UpIfcProj = env.OpenProject(@"c:\SCIA\GIThub\SciaOpenAPI_example_CSS.mat\res\empty.with.mat.lib.esa");
            env.UpdateProject(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeIFC, @"c:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\ifc\test.ifc", UpIfcProj.ProjectID);
            UpIfcProj.CloseProject(EnvESA80.TEnvESAApp_SaveChanges.eEPSaveChangesNo);
            
            SCIA.OpenAPI.EsaProject UpRevitProj = env.OpenProject(@"c:\SCIA\GIThub\SciaOpenAPI_example_CSS.mat\res\empty.with.mat.lib.esa");
            env.UpdateProject(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeRevit, @"c:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\revit\test.r2s", UpRevitProj.ProjectID);
            UpRevitProj.CloseProject(EnvESA80.TEnvESAApp_SaveChanges.eEPSaveChangesNo);
            
            SCIA.OpenAPI.EsaProject UpTeklaProj = env.OpenProject(@"c:\SCIA\GIThub\SciaOpenAPI_example_CSS.mat\res\empty.with.mat.lib.esa");
            env.UpdateProject(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeTekla, @"c:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\tekla\test.t2s",UpTeklaProj.ProjectID);
            UpTeklaProj.CloseProject(EnvESA80.TEnvESAApp_SaveChanges.eEPSaveChangesNo);
            
            SCIA.OpenAPI.EsaProject UpXlsxProj = env.OpenProject(@"c:\SCIA\GIThub\SciaOpenAPI_example_CSS.mat\res\empty.with.mat.lib.esa");
            env.UpdateProject(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeAEF, @"c:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\aef\test.xlsx", UpXlsxProj.ProjectID);
            UpXlsxProj.CloseProject(EnvESA80.TEnvESAApp_SaveChanges.eEPSaveChangesNo);

            //==========================================================
            Guid newXmlproject;
            //Guid newEsaproject;
            Guid newIfcproject;
            Guid newRevitproject;
            Guid newTeklaproject;
            Guid newAefproject;

            EsaProject ImXmlpProj = env.ImportProjectFromFile(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeXML, @"C:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\xml\test.xml", out newXmlproject);
            //ESA project cannot be "imported" into SEn...just opened //EsaProject ImpEsaProj = env.ImportProjectFromFile(@"C:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\esa\test.esa", out newEsaproject);
            EsaProject ImpIfcProj = env.ImportProjectFromFile(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeIFC, @"C:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\ifc\test.ifc", out newIfcproject);
            EsaProject ImpRevitProj = env.ImportProjectFromFile(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeRevit, @"C:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\revit\test.r2s", out newRevitproject);
            EsaProject ImpTeklaProj = env.ImportProjectFromFile(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeTekla, @"C:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\tekla\test.t2s", out newTeklaproject);
            EsaProject ImpAefProj = env.ImportProjectFromFile(SCIA.OpenAPI.Environment.TypeOfExtProject.TypeAEF, @"C:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\aef\test.xlsx", out newAefproject);

            env.CloseAllProjects(EnvESA80.TEnvESAApp_SaveChanges.eEPSaveChangesNo);

        }
    }
}
