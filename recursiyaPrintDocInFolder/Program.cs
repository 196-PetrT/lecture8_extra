// Как посмотреть содержимое папки?
// Решение некоторых задач

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalogs = new DirectoryInfo(path);
    foreach (var currentCatalog in catalogs.GetDirectories())
    {
        System.Console.WriteLine($"{indent}{currentCatalog.Name}");
        CatalogInfo(currentCatalog.FullName, indent + " ");
    }
    foreach (var item in catalogs.GetFiles())
    {
        Console.WriteLine($"{indent}{item.Name}");
    }
}

string path = @"C:\Downloaded"; // без @ выдает ошибку
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);
CatalogInfo(path);
