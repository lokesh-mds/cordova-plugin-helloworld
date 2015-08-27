using WP8CordovaClassLib.Cordova;
using WP8CordovaClassLib.Cordova.Commands;
using WP8CordovaClassLib.Cordova.JSON;

namespace Cordova.Extension.Commands
{
    public class Hello : BaseCommand
    {
        public void greet(string args)
        {
            string name = JsonHelper.Deserialize<string>(args);
            string message = "Hello, " + name;
            PluginResult result = new PluginResult(PluginResult.Status.OK, message);
            DispatchCommandResult(result);
        }
    }
}
