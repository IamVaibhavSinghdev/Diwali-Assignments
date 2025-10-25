public class LongestStringLength {
    public static void main(String[] args) {
        // Example input array
        String[] words = {"apple", "banana", "grapefruit", "kiwi", "strawberry"};

        int maxLength = 0;

        for (String word : words) {
            if (word.length() > maxLength) {
                maxLength = word.length();
            }
        }

        System.out.println("The length of the longest string is: " + maxLength);
    }
}
