namespace DesignPatterns.Facade.SubSystem.DatabaseBackup
{
    public class DatabaseBackupService : IBackupRepository
    {
        public void Execute()
        {
            Console.WriteLine("Execute in DatabaseBackupService");
        }
    }

}
