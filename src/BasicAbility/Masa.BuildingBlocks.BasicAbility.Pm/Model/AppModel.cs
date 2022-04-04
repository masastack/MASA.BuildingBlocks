namespace Masa.BuildingBlocks.BasicAbility.Pm.Model
{
    public class AppModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Identity { get; set; }

        public int ProjectId { get; set; }

        public AppModel(int id, string name, string identity, int projectId)
        {
            Id = id;
            Name = name;
            Identity = identity;
            ProjectId = projectId;
        }
    }
}
