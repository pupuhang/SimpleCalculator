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
        int secondNumber = 0;
        // 내부 연산자 저장 변수
        string currentOperator = "";
        bool isOperatorClicked = false;
        // 여러 숫자 버튼을 하나의 이벤트로 처리
        private void btnNumber_Click(object sender, EventArgs e)
        {
            // 클릭된 버튼을 Button 타입으로 변환
            Button btn = sender as Button;

            //이전 계산 결과가 있으면 초기화
            if (txtDisplay.Text.Contains("="))
            {
                txtDisplay.Clear();
            }
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
            if (!isOperatorClicked) return;

            // 연산자 찾기
            int opPos = txtDisplay.Text.IndexOf(" ");
            // 두 번째 숫자 추출
            string secondText = txtDisplay.Text.Substring(opPos + 3);
            // 두 번째 숫자 없으면 firstNumber 그대로 출력
            if (string.IsNullOrWhiteSpace(secondText))
            {
                txtResult.Text = firstNumber.ToString();
                txtDisplay.Text = $"{firstNumber} = {firstNumber}";
                isOperatorClicked = false; // 상태 초기화
                return;
            }

            // 안전한 숫자 변환
            if (!int.TryParse(secondText, out secondNumber))
            {
                MessageBox.Show("숫자 형식이 올바르지 않습니다.");
                return;
            }


            int result = 0; // 결과 변수

            // 내부 연산자로 계산 수행
            if (currentOperator == "+") // 더하기
                result = firstNumber + secondNumber;
            else if (currentOperator == "-") // 빼기
                result = firstNumber - secondNumber;
            else if (currentOperator == "*") // 곱하기
                result = firstNumber * secondNumber;
            else if (currentOperator == "/") // 나누기
            {
                if (secondNumber == 0) // 0 나누기 방지
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.");
                    return;
                }
                result = firstNumber / secondNumber; // 나눗셈
            }
            // 결과를 문자열로 변환하여 결과창에 출력
            txtResult.Text = result.ToString();

            // 화면에는 ÷와 x로 다시 표시
            string displayOperator = currentOperator;

            if (currentOperator == "/")
                displayOperator = "÷";
            else if (currentOperator == "*")
                displayOperator = "x";

            //문자열 정수 변환
            txtResult.Text = result.ToString();
            //입력창 출력
            txtDisplay.Text += " = " + result;
            // 상태 초기화
            isOperatorClicked = false;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            // 입력값 없으면 종료
            if (txtDisplay.Text == "") return;
            //결과 상태 처리
            if (txtDisplay.Text.Contains("="))
            {
                txtDisplay.Text = txtResult.Text;
            }
            if (isOperatorClicked && !txtDisplay.Text.Contains("="))
            {
                // 먼저 계산
                btnEqual_Click(sender, e);
                // 결과를 다음 계산으로 사용
                txtDisplay.Text = txtResult.Text; 
            }
            // 클릭된 버튼 가져오기
            Button btn = sender as Button;
            // 첫 번째 숫자 저장
            firstNumber = int.Parse(txtDisplay.Text);

            //버튼 Text를 내부 연산자로 변환
            if (btn.Text == "÷") // 나누기 버튼이면
                currentOperator = "/"; 
            else if (btn.Text == "x") // 곱하기 버튼이면
                currentOperator = "*"; // 내부는 * 사용
            else
                currentOperator = btn.Text; // 나머지는 그대로 사용
            // 연산자 입력 상태로 변경
            isOperatorClicked = true;
            //화면에 입력 출력
            txtDisplay.Text += " " + btn.Text + " ";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 입력창 초기화
            txtDisplay.Clear();
            // 결과창 초기화
            txtResult.Clear();
            // 첫 번째 숫자 초기화
            firstNumber = 0;
            // 연산자 초기화
            currentOperator = ""; 
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            //결과가 나오고 누르면 초기화
            if (txtDisplay.Text.Contains("="))
            {
                txtDisplay.Clear();   // 입력창 초기화
                txtResult.Clear();    // 결과창 초기화
                firstNumber = 0;      // 값 초기화
                secondNumber = 0;
                currentOperator = "";
                isOperatorClicked = false;
                return;
            }
            // 연산자가 있는 경우
            if (txtDisplay.Text.Contains(" + ") ||
                txtDisplay.Text.Contains(" - ") ||
                txtDisplay.Text.Contains(" x ") ||
                txtDisplay.Text.Contains(" ÷ "))
            {
                //연산자 위치 찾기
                int opPos = txtDisplay.Text.IndexOf(" ");

                //마지막 숫자만 제거
                txtDisplay.Text = txtDisplay.Text.Substring(0, opPos + 3);
            }
            else
            {
                // 연산자 없으면 전체 삭제
                txtDisplay.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 글자가 있을 때만 실행
            if (txtDisplay.Text.Length > 0)
            {
                // 마지막 글자 제거
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1); 
            }
        }
    }
}
