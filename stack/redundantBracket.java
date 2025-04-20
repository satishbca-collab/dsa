

class Solution {
    public static int checkRedundancy(String s) {
        // code here
        Stack<Character> st = new Stack<>();
        for(char ch : s.toCharArray()){
            if(ch == ')'){
                boolean isRedundant = true;
                char top = st.pop();
                while(top != '('){
                    if(top == '+' || top == '-' || top == '*' || top == '/'){
                        isRedundant  = false;
                    }
                    top = st.pop();
                }
                if(isRedundant  == true){
                    return 1;
                }
            }
            else {
                st.push(ch);
            }
        }
        return 0;
    }
}
        