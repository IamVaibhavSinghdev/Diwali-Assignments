package Day_4;

public class Missing_Number {
    
    public int findMissing(int[] arr) {
    int n = arr.length;
    int totalSum = n * (n + 1) / 2;
    int arrSum = 0;
    for (int num : arr) {
        arrSum += num;
    }
    return totalSum - arrSum;
}

}
