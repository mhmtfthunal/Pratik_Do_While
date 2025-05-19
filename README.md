# Pratik_Do_While

Bu çalışma, C# dilinde **`while`** ve **`do-while`** döngülerinin farklı çalışma mantıklarını bir örnekle karşılaştırmak amacıyla hazırlanmıştır.

---

## 📊 Amaç
Kullanıcıdan bir "limit" değeri alınır ve sayaç 0'dan başlayarak bu limite kadar "Ben bir Patika'lıyım" yazdırılır. Kod hem `while` hem de `do-while` ile yazılmıştır.

---

### ⚠️ Açıklama:
- Koşul **en başta** kontrol edilir.
- Eğer kullanıcı -5 gibi bir değer girerse, `sayac <= limit` koşulu sağlanmaz ve döngü **hiç çalışmaz.**

---


### ✅ Açıklama:
- `do-while` döngüsünde **önce içerisi çalışır**, sonra koşul kontrol edilir.
- Bu nedenle kullanıcı -5 bile girse, **en az 1 kez çalışır.**

---

## 📝 Fark Özeti

| Karşılaştırma         | while                                | do-while                           |
|------------------------|--------------------------------------|-------------------------------------|
| Koşul kontrol yeri     | En başta                             | En sonda                            |
| En az 1 kez çalışır mı? | Hayır                                | **Evet**                            |
| Kullanıcı -5 girerse  | Hiçbir satır yazılmaz               | 1 kez "Ben bir Patika'lıyım" yazar |

---
