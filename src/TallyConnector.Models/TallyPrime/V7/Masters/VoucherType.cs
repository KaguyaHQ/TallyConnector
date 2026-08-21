namespace TallyConnector.Models.TallyPrime.V7.Masters;

[XmlRoot(ElementName = "VOUCHERTYPE")]
[XmlType(AnonymousType = true)]
[GenerateITallyRequestableObect]
[GenerateMeta]
public partial class VoucherType : V6.Masters.VoucherType
{
    [XmlElement(ElementName = "VOUCHERNUMBERSERIES.LIST")]
    [TDLCollection(CollectionName = "VOUCHERNUMBERSERIES")]
    public List<VoucherNumberSeries>? NumberingSeries { get; set; }
}

public partial class VoucherNumberSeries
{
    [XmlElement(ElementName = "NAME")]
    public string? Name { get; set; }

    [XmlElement(ElementName = "NUMBERINGMETHOD")]
    public string? NumberingMethod { get; set; }
}
