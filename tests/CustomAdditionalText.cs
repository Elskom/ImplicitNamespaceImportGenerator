namespace ImplicitNamespaceImportGenerator.Tests;

internal class CustomAdditionalText : AdditionalText
{
    private readonly string _text;

    public override string Path { get; }

    public CustomAdditionalText(string path, string text)
    {
        Path = path;
        _text = text;
    }

    public override SourceText? GetText(CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        return SourceText.From(_text);
    }
}
