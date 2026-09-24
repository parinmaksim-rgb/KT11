Вариант 1. Геометрические фигуры
1. IShape { double Area(); double Perimeter(); } — базовый интерфейс.
2. IDrawable : IShape { string Draw(); } — расширяющий интерфейс, возвращающий текстовое представление фигуры (например, упрощённый ASCII-рисунок).
3. Реализуйте Circle и Rectangle, реализующие только IShape.
4. Реализуйте Triangle, реализующий IDrawable (а значит, и IShape).
5. Соберите все фигуры в List<IShape>, обойдите в цикле: выведите площадь и периметр каждой, а для тех, что дополнительно реализуют IDrawable (проверка через is), дополнительно выведите результат Draw().
<img width="2517" height="939" alt="image" src="https://github.com/user-attachments/assets/a26291c2-8cf6-408d-b14c-5d350260e97f" />
<img width="737" height="758" alt="image" src="https://github.com/user-attachments/assets/1ac1e4f3-af75-4070-a39f-b5789a10058e" />
<img width="677" height="457" alt="image" src="https://github.com/user-attachments/assets/38d65ffd-7762-47d3-a9ce-1c83065eeb1d" />
<img width="724" height="420" alt="image" src="https://github.com/user-attachments/assets/2970b633-4e2c-42c6-bba8-0a967b626db6" />
<img width="486" height="218" alt="image" src="https://github.com/user-attachments/assets/af5173d6-3d9a-4cf0-9493-c0f4b447b768" />
<img width="397" height="238" alt="image" src="https://github.com/user-attachments/assets/905771fb-7d8d-481c-943b-349d7a994d6f" />

