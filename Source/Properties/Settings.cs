using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace JeutieControl.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  public sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default => Settings.defaultInstance;

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("Path has not been set yet.")]
    public string ServerPath
    {
      get => (string) this[nameof (ServerPath)];
      set => this[nameof (ServerPath)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("Path has not been set yet.")]
    public string MySQLPath
    {
      get => (string) this[nameof (MySQLPath)];
      set => this[nameof (MySQLPath)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("Path has not been set yet.")]
    public string ApachePath
    {
      get => (string) this[nameof (ApachePath)];
      set => this[nameof (ApachePath)] = (object) value;
    }

    [DefaultSettingValue("False")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool KeepOnTop
    {
      get => (bool) this[nameof (KeepOnTop)];
      set => this[nameof (KeepOnTop)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("User")]
    public string MachineName
    {
      get => (string) this[nameof (MachineName)];
      set => this[nameof (MachineName)] = (object) value;
    }

    private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
    {
    }

    private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
    {
    }
  }
}
