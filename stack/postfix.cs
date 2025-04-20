public class Solution {
    public int EvalRPN(string[] tokens) {
        if(tokens.Length == 1){
            return Convert.ToInt32(tokens[0]);
        }
        Stack<string> st = new Stack<string>();
        st.Push(tokens[0]);
        st.Push(tokens[1]);
        int i = 2, a, b;
        while(i < tokens.Length){
            switch(tokens[i])
            {
                case "+":
                            b = Convert.ToInt32(st.Pop());
                            a = Convert.ToInt32(st.Pop());
                            st.Push((a + b).ToString());
                            break;
                case "-":
                            b = Convert.ToInt32(st.Pop());
                            a = Convert.ToInt32(st.Pop());
                            st.Push((a - b).ToString());
                            break;
                case "*":
                            b = Convert.ToInt32(st.Pop());
                            a = Convert.ToInt32(st.Pop());
                            st.Push((a * b).ToString());
                            break;
                case "/": 
                            b = Convert.ToInt32(st.Pop());
                            a = Convert.ToInt32(st.Pop());
                            st.Push((a / b).ToString());
                            break;
                default:
                            st.Push(tokens[i]);
                            break;
            }
            i++;
        }
        return Convert.ToInt32(st.Pop());
    }
}