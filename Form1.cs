namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 첫 번째 숫자를 저장하는 변수
        int firstNumber = 0;
        // 내부 연산자 저장 변수
        string currentOperator = "";
        // 여러 숫자 버튼을 하나의 이벤트로 처리
        private void btnNumber_Click(object sender, EventArgs e)
        {
            // 클릭된 버튼을 Button 타입으로 변환
            Button btn = sender as Button;
            // 버튼의 Text 값을 가져와 입력창에 누적
            txtDisplay.Text += btn.Text;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEqual_Click(sender, e);
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //입력창이 비어있으면 연산을 수행하지 않음
            if (txtDisplay.Text == "") return;
            // 두 번째 숫자를 정수로 변환
            int secondNumber = int.Parse(txtDisplay.Text);
            // 두 수를 더한 결과 계산
            int result = firstNumber + secondNumber;

            // 결과를 문자열로 변환하여 결과창에 출력
            txtResult.Text = result.ToString();

            // 계산식 표시
            txtDisplay.Text = $"{firstNumber} + {secondNumber} = {result}";
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            // 입력값 없으면 종료
            if (txtDisplay.Text == "") return; 
            // 클릭된 버튼 가져오기
            Button btn = sender as Button; 
            // 첫 번째 숫자 저장
            firstNumber = int.Parse(txtDisplay.Text); 

            //버튼 Text를 내부 연산자로 변환
            if (btn.Text == "÷") // 나누기 버튼이면
                currentOperator = "/"; // 내부는 / 사용
            else
                currentOperator = btn.Text; // 나머지는 그대로 사용
            // 다음 입력을 위해 초기화
            txtDisplay.Clear(); 
        }
    }
}
