using GameFifteen.Contracts;
using System.Text;

namespace Matrica.Tests.Mocks
{
    public class LoggerMock : ILogger
    {
        public LoggerMock()
        {
            this.Text = new StringBuilder();
        }

        public StringBuilder Text { get; private set; }

        public void Write(string text)
        {
            this.Text.Append(text);
        }

        public void WriteLine(string text)
        {
            this.Text.Append(text);
        }
    }
}
