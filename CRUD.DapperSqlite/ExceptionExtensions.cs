namespace CRUD.DapperSqlite
{
    internal static class ExceptionExtensions
    {
        public static void ShowErro(this Exception ex, string title = "Erro")
        {
            // Get reference to the dialog type.
            var dialogTypeName = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
            var dialogType = typeof(Form).Assembly.GetType(dialogTypeName);

            if (dialogType != null)
            {
                // Create dialog instance.
                var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());

                // Populate relevant properties on the dialog instance.
                dialog.Text = title;
                dialogType.GetProperty("Details").SetValue(dialog, ex.StackTrace, null);
                dialogType.GetProperty("Message").SetValue(dialog, ex.Message, null);

                // Display dialog.
                dialog.ShowDialog();
            }
            else
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
