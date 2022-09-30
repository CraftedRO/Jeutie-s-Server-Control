using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace JeutieControl.Properties
{
  [CompilerGenerated]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) JeutieControl.Properties.Resources.resourceMan, (object) null))
          JeutieControl.Properties.Resources.resourceMan = new ResourceManager("JeutieControl.Properties.Resources", typeof (JeutieControl.Properties.Resources).Assembly);
        return JeutieControl.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => JeutieControl.Properties.Resources.resourceCulture;
      set => JeutieControl.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap GreenCheck => (Bitmap) JeutieControl.Properties.Resources.ResourceManager.GetObject(nameof (GreenCheck), JeutieControl.Properties.Resources.resourceCulture);

    internal static Bitmap GreenCheck1 => (Bitmap) JeutieControl.Properties.Resources.ResourceManager.GetObject(nameof (GreenCheck1), JeutieControl.Properties.Resources.resourceCulture);

    internal static Bitmap GreenCheck2 => (Bitmap) JeutieControl.Properties.Resources.ResourceManager.GetObject(nameof (GreenCheck2), JeutieControl.Properties.Resources.resourceCulture);

    internal static Bitmap RedX => (Bitmap) JeutieControl.Properties.Resources.ResourceManager.GetObject(nameof (RedX), JeutieControl.Properties.Resources.resourceCulture);
  }
}
