namespace ITI_Tasks.Lab2;

public class HiringDate {
    private int month;
    private int year;
    private int day;

    public HiringDate(int day, int month, int year) {
        this.month = month;
        this.year = year;
        this.day = day;
    }

    public int CompareTo(HiringDate other) {
        if (year == other.year && month == other.month) {
            return this.day.CompareTo(other.day);
        }

        if (year == other.year) {
            return this.month.CompareTo(other.month);
        }

        return year.CompareTo(other.year);
    }


    public bool Equals(HiringDate h) {
        return h.day == day && h.month == month && h.year == year;
    }


    public override string ToString() {
        return $"{day}/{month}/{year}";
    }
}