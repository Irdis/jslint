using System.Text;
using System.Text.Json;

using var input = Console.OpenStandardInput();
using var output = Console.OpenStandardOutput();
using var writer = new Utf8JsonWriter(output, new JsonWriterOptions {
    Indented = true
});

var document = JsonDocument.Parse(input);

document.WriteTo(writer);

