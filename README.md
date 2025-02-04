# GPA

Nontiwat Nonkhamchan 673450196-2

โปรแกรมนี้เป็น **GPA Calculator** สำหรับคำนวณเกรดเฉลี่ยของนักศึกษา  
สามารถคำนวณ **GPAx (ค่าเฉลี่ย), GPA สูงสุด, GPA ต่ำสุด และ จำนวนคนที่ป้อนเกรด**  

##  Features
- เพิ่มเกรดนักศึกษาและคำนวณ GPA
- แสดง **ค่าเฉลี่ย GPA, จำนวนคน, คะแนนสูงสุด, คะแนนต่ำสุด**
- ใช้ **WinForms (C#)** ในการพัฒนา

##  Class Diagram
```mermaid
classDiagram
    class Form1 {
        - List<double> gpaList
        + Form1()
        + void button1_Click(object sender, EventArgs e)
        + void UpdateGPAInfo()
    }

    Form1 --> Listdouble : ใช้เก็บข้อมูล GPA

    class Listdouble {
        + Add(double item)
        + double Average()
        + double Max()
        + double Min()
        + int Count
    }
