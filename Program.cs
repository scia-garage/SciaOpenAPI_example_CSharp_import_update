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


            Guid TypeXml;
            Guid TypeEsa;
            Guid TypeIfc;
            Guid TypeRevit;
            Guid TypeTekla;
            Guid TypeAef;
            Guid.TryParse("00000000-0000-0000-0000-000000000000", out TypeXml);
            Guid.TryParse("8FAB15C8-E199-4bca-847A-A81920507B17", out TypeEsa);
            Guid.TryParse("23C8CDBC-04E7-4576-9F7A-CBA54952E373", out TypeIfc);
            Guid.TryParse("AFA9833D-152B-4ce0-80D7-3551FF2C99FB", out TypeRevit);
            Guid.TryParse("D2B9877D-5382-45c9-BEBF-2C078C5A5FC2", out TypeTekla);
            Guid.TryParse("C5726574-9488-4A3D-A790-DF0156943790", out TypeAef);

            SCIA.OpenAPI.EsaProject UpXmlProj = env.OpenProject(@"c:\SCIA\GIThub\SciaOpenAPI_example_CSS.mat\res\empty.with.mat.lib.esa");
            env.UpdateProject(TypeXml, @"c:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\xml\test.xml", UpXmlProj.ProjectID);


            SCIA.OpenAPI.EsaProject UpEsaProj = env.OpenProject(@"c:\SCIA\GIThub\SciaOpenAPI_example_CSS.mat\res\empty.with.mat.lib.esa");
            env.UpdateProject(TypeEsa, @"c:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\esa\test.esa", UpEsaProj.ProjectID);

            SCIA.OpenAPI.EsaProject UpIfcProj = env.OpenProject(@"c:\SCIA\GIThub\SciaOpenAPI_example_CSS.mat\res\empty.with.mat.lib.esa");
            env.UpdateProject(TypeIfc, @"c:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\ifc\test.ifc", UpIfcProj.ProjectID);

            SCIA.OpenAPI.EsaProject UpRevitProj = env.OpenProject(@"c:\SCIA\GIThub\SciaOpenAPI_example_CSS.mat\res\empty.with.mat.lib.esa");
            env.UpdateProject(TypeRevit, @"c:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\revit\test.r2s", UpRevitProj.ProjectID);

            //SCIA.OpenAPI.EsaProject UpTeklaProj = env.OpenProject(@"c:\SCIA\GIThub\SciaOpenAPI_example_CSS.mat\res\empty.with.mat.lib.esa");
            //env.UpdateProject(TypeTekla, @"c:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\tekla\test.t2s",UpTeklaProj.ProjectID);
                    
            SCIA.OpenAPI.EsaProject UpXlsxProj = env.OpenProject(@"c:\SCIA\GIThub\SciaOpenAPI_example_CSS.mat\res\empty.with.mat.lib.esa");
            env.UpdateProject(TypeAef, @"c:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\aef\test.xlsx", UpXlsxProj.ProjectID);

            //==========================================================
            Guid newXmlproject;
            //Guid newEsaproject;
            Guid newIfcproject;
            Guid newRevitproject;
            //Guid newTeklaproject;
            Guid newAefproject;

            EsaProject ImXmlpProj = env.ImportProjectFromFile(@"C:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\xml\test.xml", out newXmlproject);
            //ESA project cannot be "imported" into SEn...just opened //EsaProject ImpEsaProj = env.ImportProjectFromFile(@"C:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\esa\test.esa", out newEsaproject);
            EsaProject ImpIfcProj = env.ImportProjectFromFile(@"C:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\ifc\test.ifc", out newIfcproject);
            EsaProject ImpRevitProj = env.ImportProjectFromFile(@"C:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\revit\test.r2s", out newRevitproject);
            //EsaProject ImpTeklaProj = env.ImportProjectFromFile(@"C:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\tekla\test.t2s", out newTeklaproject);
            EsaProject ImpAefProj = env.ImportProjectFromFile(@"C:\SCIA\GIThub\SciaOpenAPI_example_cs_import_update\res\aef\test.xlsx", out newAefproject);

            env.CloseAllProjects(EnvESA80.TEnvESAApp_SaveChanges.eEPSaveChangesNo);

        }
    }
}
