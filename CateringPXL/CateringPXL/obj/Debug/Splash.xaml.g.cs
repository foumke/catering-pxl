//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CateringPXL {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class Splash : ContentPage {
        
        private ActivityIndicator indicator;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(Splash));
            indicator = this.FindByName<ActivityIndicator>("indicator");
        }
    }
}
