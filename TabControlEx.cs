using System.Collections.Generic;
using System.Windows.Forms;

namespace RedisAdmin
{
    public class TabControlEx : TabControl
    {
        private Dictionary<TabPage,int> HiddenTabPages { get; set; }

        public TabControlEx()
        {
            this.HiddenTabPages = new Dictionary<TabPage, int>();
        }

        public void HideTab( TabPage Page )
        {
            var index = this.TabPages.IndexOf( Page );
            if( index < 0 ) return;
            this.TabPages.Remove( Page );
            this.HiddenTabPages.Add( Page, index );
        }

        public void ShowTab( TabPage Page )
        {
            if( !this.HiddenTabPages.ContainsKey( Page ) ) return;
            this.TabPages.Insert( this.HiddenTabPages[Page], Page );
            this.HiddenTabPages.Remove( Page );
        }
    }
}
