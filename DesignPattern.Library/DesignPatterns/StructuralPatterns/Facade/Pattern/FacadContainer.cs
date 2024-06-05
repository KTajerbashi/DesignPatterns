using DesignPatterns.StructuralPatterns.Facade.Pattern.SubSystem.DatabaseBackup;
using DesignPatterns.StructuralPatterns.Facade.Pattern.SubSystem.DrawContainer;
using DesignPatterns.StructuralPatterns.Facade.Pattern.SubSystem.EmailContainer;

namespace DesignPatterns.StructuralPatterns.Facade.Pattern
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
