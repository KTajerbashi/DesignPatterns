using DesignPatterns.StructuralPatterns.Facade.Pattern.SubSystem.DatabaseBackup;
using DesignPatterns.StructuralPatterns.Facade.Pattern.SubSystem.DrawContainer;
using DesignPatterns.StructuralPatterns.Facade.Pattern.SubSystem.EmailContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Facade.Pattern
{
    public interface IFacadContainer
    {
        IBackupRepository BackupRepository { get; }
        IEmailRepository EmailRepository { get; }
        IDrawRepository DrawRepository { get; }
    }
}
