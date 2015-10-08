using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CatchTheButton.Behaviors
{
    public class EntryScalingBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.Focused += Bindable_Focused;
            bindable.Unfocused += Bindable_Unfocused;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.Focused -= Bindable_Focused;
            bindable.Unfocused -= Bindable_Unfocused;
            base.OnDetachingFrom(bindable);
        }

        async void Bindable_Unfocused(object sender, FocusEventArgs e)
        {
            var entry = (Entry)sender;
            await entry.ScaleTo(1);
        }

        async void Bindable_Focused(object sender, FocusEventArgs e)
        {
            var entry = (Entry)sender;
            await entry.ScaleTo(1.1);
        }
    }
}
