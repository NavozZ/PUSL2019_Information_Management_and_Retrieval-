using System;

namespace MetroFramework
{
    internal class Controls
    {
        internal class MetroTabControl
        {
            public MetroTabControl()
            {
            }

            public object Controls { get; internal set; }

            internal void SuspendLayout()
            {
                throw new NotImplementedException();
            }
        }

        internal class MetroTextBox
        {
        }
    }
}