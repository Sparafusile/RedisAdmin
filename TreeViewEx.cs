using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RedisAdmin
{
    public class TreeNodeEx : TreeNode
    {
        private Dictionary<TreeNodeEx, int> Hidden { get; set; }

        public TreeNodeEx( string text, int imageIndex, int selectedImageIndex ) : base( text, imageIndex, selectedImageIndex )
        {
            this.Hidden = new Dictionary<TreeNodeEx, int>();
        }

        public void HideNode( TreeNodeEx Node )
        {
            var index = this.Nodes.IndexOf( Node );
            if( index < 0 ) return;
            this.Nodes.Remove( Node );
            this.Hidden.Add( Node, index );
        }

        public void ShowNode( TreeNodeEx Node )
        {
            if( !this.Hidden.ContainsKey( Node ) ) return;
            this.Nodes.Insert( this.Hidden[Node], Node );
            this.Hidden.Remove( Node );
        }

        public void ShowAll()
        {
            foreach( var Node in this.Hidden.OrderBy( m => m.Value ) )
            {
                this.Nodes.Insert( Node.Value, Node.Key );
            }
            this.Hidden = new Dictionary<TreeNodeEx, int>();
        }
    }

    public class TreeViewEx : TreeView
    {
        private Dictionary<TreeNodeEx, int> Hidden { get; set; }

        public TreeViewEx()
        {
            this.Hidden = new Dictionary<TreeNodeEx, int>();
        }

        public void HideNode( TreeNodeEx Node )
        {
            var index = this.Nodes.IndexOf( Node );
            if( index < 0 ) return;
            this.Nodes.Remove( Node );
            this.Hidden.Add( Node, index );
        }

        public void ShowNode( TreeNodeEx Node )
        {
            if( !this.Hidden.ContainsKey( Node ) ) return;
            this.Nodes.Insert( this.Hidden[Node], Node );
            this.Hidden.Remove( Node );
        }

        public void ShowAll()
        {
            foreach( var Node in this.Hidden.OrderBy( m => m.Value ) )
            {
                this.Nodes.Insert( Node.Value, Node.Key );
            }
            this.Hidden = new Dictionary<TreeNodeEx, int>();
        }
    }
}
