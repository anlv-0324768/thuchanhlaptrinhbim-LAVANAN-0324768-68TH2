using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Collections.Generic;

namespace ClassLibrary3
{
    [Transaction(TransactionMode.Manual)]
    public class Class1 : IExternalCommand
    {
        public Result Execute(
            ExternalCommandData commandData,
            ref string message,
            ElementSet elements)
        {
            UIDocument uidoc =
                commandData.Application.ActiveUIDocument;

            ICollection<ElementId> selectedIds =
                uidoc.Selection.GetElementIds();

            Autodesk.Revit.UI.TaskDialog.Show(
                "Revit",
                "Số lượng đối tượng được chọn: "
                + selectedIds.Count.ToString());
            // Khởi tạo các danh sách (List) rỗng để chuẩn bị phân loại và lưu ID của Tường, Cột, Dầm, Sàn
            ICollection<ElementId> selectedWallIds = new List<ElementId>();
            ICollection<ElementId> selectedCollumIds = new List<ElementId>();
            ICollection<ElementId> selectedBeams = new List<ElementId>();
            ICollection<ElementId> selectedFloors = new List<ElementId>();

            foreach (ElementId id in selectedIds)
            {
                Element element =
                    uidoc.Document.GetElement(id);
                // Kiểm tra các đối tượng và thêm vào danh sách tương ứng
                if (element is Wall)
                {
                    selectedWallIds.Add(id);
                }
                if (element is Floor)
                {
                    selectedFloors.Add(id);
                }
                // dùng BuiltInCategory để kiểm tra cột và dầm vì cplumn và beam có thể là các loại khác nhau

                if (element.Category?.BuiltInCategory == BuiltInCategory.OST_StructuralColumns ||
                      element.Category?.BuiltInCategory == BuiltInCategory.OST_Columns)
                {
                    selectedCollumIds.Add(id);
                }
                
                if (element.Category?.BuiltInCategory == BuiltInCategory.OST_StructuralFraming)
                {
                    selectedBeams.Add(id);
                }
                
            }

            // Chọn lại các đối tượng tường
            uidoc.Selection.SetElementIds(selectedWallIds);
            //tường
            if (selectedWallIds.Count > 0)
            {
                Autodesk.Revit.UI.TaskDialog.Show(
                    "Revit",
                    selectedWallIds.Count.ToString()
                    + " đối tượng Tường đã được chọn!");
            }
            else
            {
                Autodesk.Revit.UI.TaskDialog.Show(
                    "Revit",
                    "Không có đối tượng tường nào được chọn!");
            }
            //cột
            uidoc.Selection.SetElementIds(selectedCollumIds);
            if (selectedCollumIds.Count > 0)
            {
                Autodesk.Revit.UI.TaskDialog.Show(
                    "Revit",
                    selectedCollumIds.Count.ToString()
                    + " đối tượng Cột đã được chọn!");
            }
            else
            {
                Autodesk.Revit.UI.TaskDialog.Show(
                    "Revit",
                    "Không có đối tượng cột nào được chọn!");
            }

            {
                //dầm
                uidoc.Selection.SetElementIds(selectedBeams);

                if (selectedBeams.Count > 0)
                {
                    Autodesk.Revit.UI.TaskDialog.Show(
                        "Revit",
                        selectedBeams.Count.ToString()
                        + " đối tượng Dầm đã được chọn!");
                }
                else
                {
                    Autodesk.Revit.UI.TaskDialog.Show(
                        "Revit",
                        "Không có đối tượng Dầm nào được chọn!");
                }
            }

            {
                //sàn
                uidoc.Selection.SetElementIds(selectedFloors);
                if (selectedFloors.Count > 0)
                {
                    Autodesk.Revit.UI.TaskDialog.Show(
                        "Revit",
                        selectedFloors.Count.ToString()
                        + " đối tượng Sàn đã được chọn!");
                }
                else
                {
                    Autodesk.Revit.UI.TaskDialog.Show(
                        "Revit",
                        "Không có đối tượng Sàn nào được chọn!");
                }
            }

            return Result.Succeeded;
        }
    }
}