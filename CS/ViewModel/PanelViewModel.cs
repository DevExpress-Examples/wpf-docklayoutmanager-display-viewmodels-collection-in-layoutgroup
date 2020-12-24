using System;
using System.Linq;
using System.Windows.Media;
using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;
using DevExpress.Xpf.Docking;

namespace WpfApplication {
    public interface IDockService {
        bool Dock();
        FloatGroup Float();
    }

    public class DockService : ServiceBase, IDockService {
        LayoutPanel Panel;

        bool IDockService.Dock() {
            return Panel.GetDockLayoutManager().DockController.Dock(Panel);
        }
        FloatGroup IDockService.Float() {
            return Panel.GetDockLayoutManager().DockController.Float(Panel);
        }

        protected override void OnAttached() {
            base.OnAttached();
            Panel = AssociatedObject as LayoutPanel;
        }
    }
    public class PanelViewModel : ViewModelBase {
        public PanelViewModel(Color c) {
            ColorBrush = new SolidColorBrush(c);
            FloatCommand = new DelegateCommand(Float);
            DockCommand = new DelegateCommand(Dock);
        }

        public SolidColorBrush ColorBrush { get; set; }
        public DelegateCommand DockCommand { get; private set; }
        public DelegateCommand FloatCommand { get; private set; }
        IDockService DockService { get { return GetService<IDockService>(); } }

        void Dock() {
            DockService.Dock();
        }
        void Float() {
            DockService.Float();
        }
    }
}
