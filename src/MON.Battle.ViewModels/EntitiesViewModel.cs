using MON.Battle.IServices;
using System.Collections.Generic;

namespace MON.Battle.ViewModels
{
    public class EntitiesViewModel<TEntity> : ViewModelBase
    {
        public IEnumerable<TEntity> Entities { get; set; }

        public TEntity SelectedEntity { get; set; }

        private readonly IEntityService<TEntity> entityService;

        public EntitiesViewModel(IEntityService<TEntity> entityService)
        {
            this.entityService = entityService;

            Entities = this.entityService.Get();
        }
    }

}
