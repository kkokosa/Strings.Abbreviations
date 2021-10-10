using Xunit;

namespace String.Abbreviations.Tests
{
    public class StringsTests
    {
        [Fact]
        public void BrbNormalTest()
        {
            var str = Strings.BRB();
            Assert.Equal("Be right back", str);
        }

        [Fact]
        public void BrbTitleCaseTest()
        {
            var str = Strings.BRB(titleCase: true);
            Assert.Equal("Be Right Back", str);
        }

        [Fact]
        public void ImhoNormalTest()
        {
            var str = Strings.IMHO();
            Assert.Equal("In my humble opinion", str);
        }

        [Fact]
        public void EosTest()
        {
            var str = Strings.EOS();
            Assert.Equal("En osaa sanoa", str);
        }

        [Fact]
        public void ImhoTitleCaseTest()
        {
            var str = Strings.IMHO(titleCase: true);
            Assert.Equal("In My Humble Opinion", str);
        }

        [Fact]
        public void LmaoNormalTest()
        {
            var str = Strings.LMAO();
            Assert.Equal("Laughing my ass off", str);
        }

        [Fact]
        public void LmaoTitleCaseTest()
        {
            var str = Strings.LMAO(titleCase: true);
            Assert.Equal("Laughing My Ass Off", str);
        }

        [Fact]
        public void RotflNormalTest()
        {
            var str = Strings.ROTFL();
            Assert.Equal("Rolling on the floor laughing", str);
        }

        [Fact]
        public void RotflTitleCaseTest()
        {
            var str = Strings.ROTFL(titleCase: true);
            Assert.Equal("Rolling On The Floor Laughing", str);
        }

        [Fact]
        public void AmaNormalTest()
        {
            var str = Strings.AMA();
            Assert.Equal("Ask me anything", str);
        }

        [Fact]
        public void AmaTitleCaseTest()
        {
            var str = Strings.AMA(titleCase: true);
            Assert.Equal("Ask Me Anything", str);
        }

        [Fact]
        public void YoloNormalTest()
        {
            var str = Strings.YOLO();
            Assert.Equal("You only live once", str);
        }

        [Fact]
        public void YoloTitleCaseTest()
        {
            var str = Strings.YOLO(titleCase: true);
            Assert.Equal("You Only Live Once", str);
        }

        [Fact]
        public void LgtmNormalTest()
        {
            var str = Strings.LGTM();
            Assert.Equal("Looks good to me", str);
        }

        [Fact]
        public void LgtmTitleCaseTest()
        {
            var str = Strings.LGTM(titleCase: true);
            Assert.Equal("Looks Good To Me", str);
        }

        [Fact]
        public void TfwNormalTest()
        {
            var str = Strings.TFW();
            Assert.Equal("That feel when", str);
        }

        [Fact]
        public void TfmTitleCaseTest()
        {
            var str = Strings.TFW(titleCase: true);
            Assert.Equal("That Feel When", str);
        }

        [Fact]
        public void ScientificTest()
        {
            var ratio = Strings.GetCompressionRatio(nameof(Strings.BRB), Strings.BRB());
            Assert.Equal(0.2307692307692307692307692308M, ratio);
        }
    }
}
