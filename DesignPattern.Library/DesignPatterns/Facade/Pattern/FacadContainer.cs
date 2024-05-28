using DesignPatterns.Facade.Pattern.SubSystem.DatabaseBackup;
using DesignPatterns.Facade.Pattern.SubSystem.DrawContainer;
using DesignPatterns.Facade.Pattern.SubSystem.EmailContainer;

namespace DesignPatterns.Facade.Pattern
{
    public class FacadContainer : IFacadContainer
    {
        private IBackupRepository backupRepository;
        public IBackupRepository BackupRepository => backupRepository = backupRepository ?? new DatabaseBackupService();

        private IEmailRepository emailRepository;
        public IEmailRepository EmailRepository => emailRepository = emailRepository ?? new EmailService();

        private IDrawRepository drawRepository;
        public IDrawRepository DrawRepository => drawRepository = drawRepository ?? new DrawService();
    }
}
