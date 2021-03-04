using System;
using System.IO;
using System.Linq;

namespace UpgradeVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upgrading versions");
            string jsonFile, Version, PackageType;
            Console.WriteLine("Retrieving args");          
            RetrieveArguments( args, out jsonFile, out Version, out PackageType);
            Console.WriteLine("Retrieved args");

            if(PackageType == "Framework")
            {
                if( ReplaceVersionForArcelorMittalPackages(jsonFile, Version))
                {
                    Console.WriteLine("Succes");
                    return;
                }

            }else
            {
                if( ReplaceOnlyPackageVersion(jsonFile, Version))
                {
                    Console.WriteLine("Succes");
                    return;
                }
            }
            throw new Exception("Failed to upgrade the version");
        }

        private static void RetrieveArguments(string[] args, out string jsonFile, out string version, out string PackageType)
        {
            jsonFile = "package.json";
            version = "99.99.99";
            PackageType = "Framework";

            if (args.Count () < 1 || args.Count() > 3) throw new ArgumentException("Incorrect nr of parameters specified, specify filename and/or version and/or PackageType!");
            if (args.Count() == 1) version = args[0];
            if (args.Count() == 2) { jsonFile = args[0]; version = args[1]; }
            if (args.Count() == 3) { jsonFile = args[0]; version = args[1]; PackageType = args[2]; }

        }
        public static bool  IsPropertyPresent(dynamic setting, string name)
        {
            if (setting == null)
                return false;
            if(setting[name] != null)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// The package.json inside the generator template needs an update for the version of the dev-tools
        /// </summary>
        /// <param name="jsonFile"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public static bool ReplaceVersionForGenerator(string jsonFile , string version)
        {
                            Console.WriteLine("Replace Version For Generator");

           try
            {
                            Console.WriteLine("Reading File");
                string json = File.ReadAllText(jsonFile);
                            Console.WriteLine("Loadin Json");
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                            Console.WriteLine("Setting version for dev-tools");

                // the package.json inside the generator template
                if (IsPropertyPresent(jsonObj["devDependencies"], "@arcelormittal-frontend/dev-tools")) { jsonObj["devDependencies"]["@arcelormittal-frontend/dev-tools"] = version; }
                            Console.WriteLine("Writing Json");
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);

                                            Console.WriteLine("Writing file");
                FileInfo fsi = new FileInfo(jsonFile);
                fsi.Attributes = FileAttributes.Normal;
                File.WriteAllText(jsonFile, output);
                fsi.Attributes = FileAttributes.ReadOnly;
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
        public static bool ReplaceVersionForArcelorMittalPackages(string jsonFile , string version)
        {
                                        Console.WriteLine("Replace Version For Arcelor Mittal Packages");
            try
            {
                                        Console.WriteLine("Reading file");
                string json = File.ReadAllText(jsonFile);
                                        Console.WriteLine("Loading Json");
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                                    Console.WriteLine("updating Settings ");
                if (IsPropertyPresent(jsonObj, "version"))
                {
                    Console.WriteLine("Setting version");
                    jsonObj["version"] = version; 
                }
                                    Console.WriteLine("Setting framework versions");
                if(jsonObj["name"].ToString().StartsWith("@arcelormittal-frontend/"))
                {
                    Console.WriteLine("Set Framework versions");
                    if (IsPropertyPresent(jsonObj["dependencies"], "@arcelormittal-frontend/core")) { jsonObj["dependencies"]["@arcelormittal-frontend/core"] = version; }
                    if (IsPropertyPresent(jsonObj["dependencies"], "@arcelormittal-frontend/ui")) { jsonObj["dependencies"]["@arcelormittal-frontend/ui"] = version; }
                    if (IsPropertyPresent(jsonObj["devDependencies"], "@arcelormittal-frontend/dev-tools")) { jsonObj["devDependencies"]["@arcelormittal-frontend/dev-tools"] = version; }
                }

                            Console.WriteLine("Writing Json");
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);

                                            Console.WriteLine("Writing file");
                File.WriteAllText(jsonFile, output);

                Console.WriteLine("Checking for generator");
                //For generator-am we need to upgrade an other package.json deeper in the folder
                if(jsonObj["name"] == "@arcelormittal-frontend/generator-am")
                {
                                    Console.WriteLine("Replacing versions for template package.json");
                    string jsonFileGenerator = jsonFile.Replace("package.json",@"generators\app\templates\package.json");
                    if(!ReplaceVersionForGenerator(jsonFileGenerator, version))
                    {
                        return false;
                    }                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        public static bool ReplaceOnlyPackageVersion(string jsonFile , string version)
        {
                                        Console.WriteLine("Replace Package Version Only");
            try
            {
                                        Console.WriteLine("Reading file");
                string json = File.ReadAllText(jsonFile);
                                        Console.WriteLine("Loading Json");
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                                    Console.WriteLine("updating Settings ");
                if (IsPropertyPresent(jsonObj, "version"))
                {
                    Console.WriteLine("Setting version");
                    jsonObj["version"] = version; 
                }
                            Console.WriteLine("Writing Json");
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);

                                            Console.WriteLine("Writing file");
                File.WriteAllText(jsonFile, output);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

    }
}
