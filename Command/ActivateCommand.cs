public class ActivateCommand : Command
{
    public ActivateCommand(Argument argument) : base(argument) { }


    public override void ExecuteOnEntity(Entity entity, Map map) //this method is a TOTAL MESS
    {
        if (entity.OccupiedTile is IActivatable)
        {
            IActivatable fountain = (IActivatable)entity.OccupiedTile;
            fountain.Activate();
            entity.OccupiedTile._description = "Fountain activated!";
        }
    }
}