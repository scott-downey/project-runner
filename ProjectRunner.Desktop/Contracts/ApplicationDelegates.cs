using ProjectRunner.Common.Entities;

namespace ProjectRunner.Desktop.Contracts
{
    public delegate void OnRecordSavedEvent<T>(T record) where T : BaseEntity;

    public delegate void EditActionEvent<TUserControl, TRecord>(TUserControl sender, TRecord record) where TRecord : BaseEntity;

    public delegate void RemoveActionEvent<TUserControl>(TUserControl sender);
}
