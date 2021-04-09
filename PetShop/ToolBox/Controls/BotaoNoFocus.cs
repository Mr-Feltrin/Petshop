using System.Windows.Forms;

public class NoFocusButton : Button
{
    public override void NotifyDefault(bool value)
    {
        base.NotifyDefault(false);
    }
}