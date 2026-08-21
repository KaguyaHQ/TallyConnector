using V7VoucherType = TallyConnector.Models.TallyPrime.V7.Masters.VoucherType;

namespace TallyConnector.XmlTests.TallyPrime.V7.VoucherType;

[TestFixture]
public class VoucherTypeDeserializationTests : XmlTestBase
{
    protected override string ResourceSubPath => "TallyPrime/V7/VoucherType";

    [Test]
    public void Test_NumberingSeries_UsesEffectiveTallyPrimeValue()
    {
        var xml = File.ReadAllText(GetResourcePath("voucher_type_numbering_series.xml"));
        var voucherType = XmlTestHelper.ParseXml<V7VoucherType>(xml);

        using (Assert.EnterMultipleScope())
        {
            Assert.That(voucherType.NumberingMethod, Is.EqualTo("None"));
            Assert.That(voucherType.NumberingSeries, Has.Count.EqualTo(1));
            Assert.That(voucherType.NumberingSeries![0].Name, Is.EqualTo("Default"));
            Assert.That(
                voucherType.NumberingSeries[0].NumberingMethod,
                Is.EqualTo("Automatic (Manual Override)"));
        }
    }
}
