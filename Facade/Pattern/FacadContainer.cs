﻿using Design.Pattern.Library.Facade.SubSystem.DatabaseBackup;
using Design.Pattern.Library.Facade.SubSystem.DrawContainer;
using DesignPatterns.Facade.SubSystem.DatabaseBackup;
using DesignPatterns.Facade.SubSystem.DrawContainer;
using DesignPatterns.Facade.SubSystem.EmailContainer;

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
