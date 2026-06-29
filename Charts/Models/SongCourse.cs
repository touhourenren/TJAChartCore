using TaikoNauts.Core.Taiko.Charts.Models.Commands;

namespace TaikoNauts.Core.Taiko.Charts;

public sealed class SongCourse
{
    public int _diffculty { get; set; }
    public int _level { get; set; }
    public bool _isBranching { get; set; }
    public string _chartHash { get; set; } = string.Empty;
    public string _legacyOffsetChartHash { get; set; } = string.Empty;
    public List<int> _balloon { get; set; } = new();
    public List<int> _balloonNormal { get; set; } = new();
    public List<int> _balloonExpert { get; set; } = new();
    public List<int> _balloonMaster { get; set; } = new();
    public List<Chip> _chips { get; set; } = new();
    public List<Chip> _chipsNormal { get; set; } = new();
    public List<Chip> _chipsExpert { get; set; } = new();
    public List<Chip> _chipsMaster { get; set; } = new();
    public List<Command> _commands { get; set; } = new();
    public List<BranchCommand> _branchCommands { get; set; } = new();
}
