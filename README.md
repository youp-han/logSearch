[한국어](./README.ko.md)

## Source Code
* [FrmLogFilter.cs](./FrmLogFilter.cs)
* [core/FileUtils.cs](./core/FileUtils.cs)
* [Program.cs](./Program.cs)

---

## English

### Log Filter

A Windows Forms application that extracts lines containing a specific keyword from a given log file (.txt, .log) and saves them to a new file.

### Features
- **File Selection**: Specify a log file using the 'Find File' button or by drag-and-drop.
- **Keyword Search**: Filter logs by entering a desired search term. (Default: "error")
- **Display Results**: Shows the filtered results in a list box on the screen.
- **Save to File**: Saves the results to a separate text file. (Format: `original_filename-yyyyMMdd-filttered.txt`)
- **Open Result**: Allows you to open the saved result file directly with a button click.

### How to Use
1. Select a log file by clicking the `Find File` button or by dragging and dropping it onto the window.
2. Enter the keyword you want to search for. (The default is "error".)
3. Click the `Search` button to start the filtering process.
4. The results are displayed on the screen and saved to a file at the specified path.
5. You can check the saved file immediately by clicking the `Open Result File` button.