// B) Bản chất: record vs record struct
// 1️⃣ record (mặc định)
// public record Point(int X, int Y);


// Là reference type (giống class)

// Nằm trên heap

// Truyền qua method → truyền reference

// So sánh bằng == → so sánh theo value (đặc điểm riêng của record)

// 📌 Nghĩa là:

// Nó là class, nhưng có value-equality

// 2️⃣ record struct
// public record struct Point(int X, int Y);


// Là value type

// Thường nằm trên stack (hoặc inline trong object khác)

// Truyền qua method → copy giá trị

// So sánh == → so sánh theo value

// 📌 Nghĩa là:

// Nó là struct + có sẵn value-equality + immutability (mặc định)


/*
    u can modify the struct 
*/


// Quy tắc vàng

// Entity / Aggregate → class

// Value Object / DTO → record

// Data nhỏ, hot path → readonly record struct
public record struct Point(int X, int Y);