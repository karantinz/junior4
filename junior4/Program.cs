int totalPictures = 52;
int picturesRow = 3;

int fullRows = totalPictures / picturesRow;
int pictures = totalPictures % picturesRow;

Console.WriteLine($"Количество заполненных рядов: {fullRows}");
Console.WriteLine($"Количество картинок сверх меры: {pictures}");