using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(EmployeeWebApp.ReactConfig), "Configure")]

namespace EmployeeWebApp
{
	public static class ReactConfig
	{
		public static void Configure()
		{
            // Registration of V8 engine
            JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
            JsEngineSwitcher.Current.EngineFactories.AddV8();
        }
	}
}
