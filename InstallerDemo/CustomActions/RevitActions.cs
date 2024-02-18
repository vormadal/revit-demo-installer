using System.IO;
using WixToolset.Dtf.WindowsInstaller;

namespace CustomActions
{
    public class RevitActions
    {
        private const string FileName = "C:\\Test\\manifest.xml";

        [CustomAction]
        public static ActionResult CreateManifest(Session session)
        {
            session.Log("Begin CreateManifest");
            //TODO write manifest to file here
            File.WriteAllText(FileName, "hello?");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult DeleteManifest(Session session)
        {
            session.Log("Begin DeleteManifest");
            //TODO delete manfiest file here
            File.Delete(FileName);

            return ActionResult.Success;
        }
    }
}
