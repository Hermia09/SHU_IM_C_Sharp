using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClassLibrary_Huang0045.FileStreams
{
    public class OpenReadOrWriteWithCheck_Hua0045
    {
        public FileStream input, output;

        public StreamReader fileReader = null, fileReader_data = null, fileReader_preData = null;//read file from a text file
        public StreamWriter fileWriter = null;//writes data to text file

        //object for serializing Serializable objects in binary format
        public BinaryFormatter writeFormatter, readBinaryFormatter;

        bool FileOutput_ON = false;
        bool FileInput_ON = false;

        public string FileNameOutput = null;
        public string FileNameInput = null, FileName_InputData = null, FileName_InputPreData = null;

        //create and show dialog box enabling user to save file
        public DialogResult result;

        //public String[] fileStreams={"CHARACTER_BASED", "BYTY_BASED", "TEXT_BASED", "EXIT"};
        //public const int CHARACTER_BASED = 1, BYTY_BASED = 2, TEXT_BASED = 3, EXIT = 4
        public int Stream_Based = (int)FileStreamBasedEnum2.BYTE_BASED;

        public FileMode fileMode = FileMode.OpenOrCreate;
        /// <summary>
        /// Initializes a new instance of the<see cref="OpenReadOrWriteFileWithCheck"/>class
        /// </summary>

        public OpenReadOrWriteWithCheck_Hua0045()
        {

        }
        /// <summary>
        /// Initializes a new instance of the<see cref="OpenReadOrWriteFileWithCheck"/>class
        /// </summary>
        /// <param name="_writeON">if set to<c>true</c>[write on]</param>
        /// <param name="_readON">if set to<c>true</c>[read on]</param>


        public OpenReadOrWriteWithCheck_Hua0045(bool _writeON, bool _readON, int _streamBased)
        {
            FileOutput_ON = _writeON;
            FileInput_ON = _readON;
            Stream_Based = _streamBased;
        }//end OpenReadOrWriteFileWithCheck

        /// <summary>
        /// Initializes a new instance of the<see cref="OpenReadOrWriteFileWithCheck"/>class
        /// </summary>
        /// <param name="_writeON">if set to<c>true</c>[write on]</param>
        /// <param name="fileName">Name of the file</param>

        public OpenReadOrWriteWithCheck_Hua0045(bool _writeON, string fileName, int _streamBased)
        {
            FileOutput_ON = _writeON;
            FileNameOutput = fileName;
            Stream_Based = _streamBased;
        }

        /// <summary>
        /// Initializes a new instance of the<see cref="OpenReadOrWriteFileWithCheck"/>class
        /// </summary>
        /// <param name="_readON">if set to<c>true</c>[read on]</param>
        /// <param name="_writeON">if set to<c>true</c>[write on]</param>
        /// <param name="inputFileName">Name of the input file</param>
        /// <param name="outputFileName">Name of the output file</param>

        public OpenReadOrWriteWithCheck_Hua0045(bool _readON, bool _writeON, string inputFileName, string outputFileName, int _streamBased)
        {
            FileOutput_ON = _writeON;
            FileInput_ON = _readON;
            Stream_Based = _streamBased;

            FileNameOutput = outputFileName;
            FileNameInput = inputFileName;

            if (FileOutput_ON == true)
            {
                MessageBox.Show("FileName=" + FileNameOutput);
                CreateFileStreamAndWriteAccess(FileNameOutput);
            }
            if (FileInput_ON == true) input = getFileStreamAndReadAccess(ref FileNameInput);//modified on
        }

        public OpenReadOrWriteWithCheck_Hua0045(bool _readON, bool _writeON, string inputFileName, string outputFileName, int _streamBased, FileMode _fileMode)
        {
            FileOutput_ON = _writeON;
            FileInput_ON = _readON;
            Stream_Based = _streamBased;

            FileNameOutput = outputFileName;
            FileNameInput = inputFileName;

            if (FileOutput_ON == true)
            {
                fileMode = _fileMode;
                MessageBox.Show("FileName=" + FileNameOutput);
                CreateFileStreamAndWriteAccess(FileNameOutput);
            }
            if (FileInput_ON == true) input = getFileStreamAndReadAccess(ref FileNameInput);
        }

        /// <summary>
        /// Initializes a new instance of the<see cref="OpenReadOrWriteFileWithCheck"/>class
        /// </summary>
        /// <param name="_readON">if set to<c>true</c>[read on]</param>
        /// <param name="_writeON">if set to<c>true</c>[write on]</param>
        /// <param name="inputFilenameData">The input filename data.</param>
        /// <param name="pre_dataBeforeInputFilename">The pre_data before the input filename.</param>
        /// <param name="outputFileName">Name of the output file</param>

        public OpenReadOrWriteWithCheck_Hua0045(bool _readON, bool _writeON, string inputFilenameData, string pre_dataBeforeInputFileName, string outputFileName, int _streamBased, FileMode _fileMode)
        {
            FileOutput_ON = _writeON;
            FileInput_ON = _readON;
            Stream_Based = _streamBased;

            FileNameOutput = outputFileName;
            FileName_InputData = inputFilenameData;
            FileName_InputPreData = pre_dataBeforeInputFileName;

            if (FileOutput_ON == true) CreateFileStreamAndWriteAccess(FileNameOutput);
            if (FileInput_ON == true)
            {
                getFileStreamAndReadAccess(ref FileName_InputData);
                fileReader_data = fileReader;
                getFileStreamAndReadAccess(ref FileName_InputPreData);
                fileReader_preData = fileReader;
            }
        }
        /// <summary>
        /// Opens the file dialog2get file stream and read access.
        /// </summary>
        /// <param name="fileChooser">The file chooser</param>
        /// <param name="initialDir">The initial dir.</param>
        /// <param name="FileName">Name of the file</param>
        /// <param name="_streamBased">The _stream based.</param>
        /// <returns></returns>

        public FileStream openExistingFileViaFileDialogForReading(OpenFileDialog fileChooser, string initialDir, ref string FileName, int _streamBased)
        {
            while ((fileReader == null) || (readBinaryFormatter == null))
            {
                FileName = openDialog2ChooseFile(fileChooser, initialDir);
                //if (result == DialogResult.Cancel) Environment.Exit(0);//old one
                if (result == DialogResult.Cancel) return null;//Old one

                //if(result!=DialogResult.Cancel)

                if (FileName == string.Empty)//show error if user specified invalid file
                {
                    MessageBox.Show("InvalidFileName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (FileInput_ON)
                    {
                        #region create FileStream to obtain read access to file
                        try
                        {
                            input = new FileStream(FileName, FileMode.Open, FileAccess.Read);//open existing file for reading

                            if (Stream_Based == (int)(FileStreamBasedEnum2.TEXT_BASED))
                            {
                                fileReader = new StreamReader(input, System.Text.Encoding.UTF8, true);
                                MessageBox.Show(fileReader.CurrentEncoding.BodyName.ToString());
                            }
                            else if (Stream_Based == (int)(FileStreamBasedEnum2.BYTE_BASED)) readBinaryFormatter = new BinaryFormatter();
                            FileNameInput = FileName;
                        }
                        catch (IOException)
                        {
                            MessageBox.Show("File name=" + FileName);
                            MessageBox.Show("Error reading from File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //Environment.Exit(0);
                            //return fileReader;
                        }
                        #endregion create FileStream to obtain read access to file
                    }
                    if (FileOutput_ON)
                    {
                        #region save file via FileStream if user specified valid file
                        try
                        {
                            #region open file with write access
                            MessageBox.Show("File name(in CreateFile)=" + FileName);
                            output = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);

                            if (Stream_Based == (int)(FileStreamBasedEnumNew.TEXT_BASED)) fileWriter = new StreamWriter(output);
                            else if (Stream_Based == (int)(FileStreamBasedEnumNew.BYTE_BASED)) writeFormatter = new BinaryFormatter();

                            MessageBox.Show("File name=" + FileName);
                            #endregion open file with write access
                        }
                        #region handle exception if there is a problem opening the file
                        catch (IOException/* ex*/)
                        {
                            //notify user if file could not be opened
                            MessageBox.Show(/*ex.Message + */"Error opening/writing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Environment.Exit(0);
                        }
                        #endregion handle exception if there is a problem opening the file

                        #endregion save file via FileStream if user specified valid file
                    }//end if
                }//end else
            }//end while
            return input;
        }

        private static FileStream fileStreamOpenFile(FileStream fileStream, FileMode fileMode, FileAccess fileAccess, String fileName)
        {
            switch (fileMode)
            {
                case FileMode.Open:
                    switch (fileAccess)
                    {
                        case FileAccess.Read://Open existing file for reading
                            fileStream = new FileStream(@fileName, FileMode.Open, FileAccess.Read);
                            break;
                        case FileAccess.Write:
                            fileStream = new FileStream(@fileName, FileMode.Open, FileAccess.Write);
                            break;
                        case FileAccess.ReadWrite://Open existing file for writing
                            fileStream = new FileStream(@fileName, FileMode.Open, FileAccess.ReadWrite);//Open existing file for read and write
                            //fileStream= new FileStream(@fileName, FileMode.Open);
                            break;
                    }
                    break;
                case FileMode.Append://Open file for writing (with seek to end), if the file doesn't exist create it
                    fileStream = new FileStream(@fileName, FileMode.Append);
                    break;
                /**
                 * Robust Programming If Test.data already exists in the current directory, an IOException exception is thrown.    
                 * Use the file mode option FileMode.Create when you initialize the file stream 
                 *                      to always create a new file without throwing an exception.
                 */
                case FileMode.Create://Create new file and open it for read and write, if the file exists overwrite it
                    fileStream = new FileStream(@fileName, FileMode.Create);
                    break;
                case FileMode.CreateNew://Create new file and open it for read and write, if the file exists throw exception.
                    fileStream = new FileStream(@fileName, FileMode.CreateNew);
                    break;
            }//end switch

            return fileStream;

        }//end fileStreamOpenFile


        public FileStream getFileStreamAndReadAccess(ref string FileName)//old one was "ReadFile"
        {
            if (FileName == string.Empty)//show error if user specified invalid file
            {
                MessageBox.Show("InvalidFileName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    #region create FileStream to obtain read access to file
                    input = new FileStream(FileName, FileMode.Open, FileAccess.Read);

                    MessageBox.Show("File name=" + FileName);

                    //set file from where data is read
                    if (Stream_Based == (int)(FileStreamBasedEnumNew.TEXT_BASED))
                    {
                        //fileReader = new StreamReader(input, System.Text.Encoding.Default/*Encoding.Default*//*Encoding.UTF8*/ /*Encoding.GetEncoding,true);
                        //fileReader = new StreamReader(input, System.Encoding.GetEncoding(950),true)
                        fileReader = new StreamReader(input, System.Text.Encoding.UTF8, true);//make sure-->use 'true' here.
                        MessageBox.Show(fileReader.CurrentEncoding.BodyName.ToString());
                    }
                    else if (Stream_Based == (int)(FileStreamBasedEnumNew.BYTE_BASED)) readBinaryFormatter = new BinaryFormatter();

                    FileNameInput = FileName;

                    #endregion create FileStream to obtain read access to file
                }
                catch (IOException)
                {
                    MessageBox.Show("File name=" + FileName);
                    MessageBox.Show("Error reading from File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Environment.Exit(0);
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message + "\n" + "System.ArgumentNullException: Path cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return input;
        }//end getFileStreamAndReadAccess

        /*
         * 
         * Create and show dialog bo enabling user to choose fle
         * 
         */
        /// <summary>
        /// Opens the dialog for choosing file.
        /// </summary>
        /// <param name="fileChooser">The file chooser.</param>
        /// <param name="initialDir">The initial dir.</param>
        /// <returns></returns>

        public string openDialog2ChooseFile(OpenFileDialog fileChooser, string initialDir)
        {
            // create and show dialog box enabling user to save file
            //DialogResult result; // result of SaveFileDialog
            string fileName = ""; // name of file containing data

            using (fileChooser)
            {
                fileChooser.InitialDirectory = initialDir;
                fileChooser.CheckFileExists = false; // let user create file 
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // name of file to save data
            }//end using

            #region ensure that user clicked "OK"
            if (result == DialogResult.OK)
            {
                // show error if user specified invalid file
                if (fileName == string.Empty)
                {
                    MessageBox.Show("Invalid File Name", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("filename selected-->" + fileName);

                }//end else
            }//end if
            #endregion ensure that user clicked "OK"

            #region notify user if cancel bin is clicked
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("There is no file selected or DialogResult.Cancel!", "Exit or Re-select a new file!");
                //Environment.Exit(0);
                return null;
            }
            #endregion notify user if cancel bin is clicked


            return fileName;
        }//end openDialog2ChooseFile


        /// <summary>
        /// Creates the file
        /// </summary>
        /// <param name="FileName">Name of the file.</param>
        /// <returns></returns>

        public FileStream CreateFileStreamAndWriteAccess(string FileName)
        {
            if (FileName == string.Empty)
            {
                MessageBox.Show("InvalidFileName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                #region save file via FileStream if user specified valid file
                try
                {
                    #region open file with write access
                    MessageBox.Show("File name(in CreateFile)=" + FileName);
                    // output = new FileStream(FileName, fileMode.OpenOrCreate,FileAccess.Write);
                    output = new FileStream(FileName, fileMode, FileAccess.Write);

                    if (Stream_Based == (int)(FileStreamBasedEnum2.TEXT_BASED))
                        // fileWriter = new StreamWriter(output);//old one
                        fileWriter = new StreamWriter(output, System.Text.Encoding.BigEndianUnicode);
                    //https://twblog.hongjianching.com/2017/12/17/why-csharp-write-and-read-file-with-different-encoding-but-success/

                    else if (Stream_Based == (int)(FileStreamBasedEnum2.BYTE_BASED))
                        writeFormatter = new BinaryFormatter();

                    FileNameOutput = FileName;
                    MessageBox.Show("File name=" + FileName);
                    #endregion open file with write access
                }
                #region handle exception if there is a problem opening the file
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message + "Error opening/writing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion handle exception if there is a problem opening the file

                #endregion save file via FileStream if user specified valid file
            }
            return output;
        }//end CreateFileStreamAndWriteAccess

        /// <summary>
        /// Closes the file.
        /// </summary>

        public void CloseFile()
        {
            if (Stream_Based == (int)FileStreamBasedEnum2.TEXT_BASED)
            {
                if (fileReader != null || fileReader_data != null || fileReader_preData != null || fileWriter != null)
                {
                    try
                    {
                        if (FileOutput_ON == true)
                        {
                            fileWriter.Close();
                        }
                        if (FileInput_ON == true)
                        {
                            if (fileReader != null) fileReader.Close();
                            if (fileReader_data != null)
                            {
                                fileReader_data.Close();
                                MessageBox.Show("Close reading file!");
                            }
                            if (fileReader_preData != null) fileReader_preData.Close();
                            if (input != null) input.Close();
                        }
                        MessageBox.Show("Close writing or reading file!");
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Cannot close file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                    }
                }
                else//i.e. (Stream_Based == BYTE_BASED)
                {
                    if ((FileOutput_ON) && (output != null))
                    {
                        try
                        {
                            output.Close();//Close fileStream
                        }
                        catch (IOException)
                        {
                            MessageBox.Show("Cannot close file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }//end catch
                    }//end if
                    if ((FileInput_ON) && (output != null))
                    {
                        output.Close();//Close fileStream
                    }
                }
            }
        }//end CloseFile

        public FileStream CreateFileStreamAndWriteAccess(string FileName, OpenFileDialog _fileChooser, String _initialDir)//added 08June2021
        {
            if (FileName == string.Empty)
            {
                //MessageBox.Show("InvalidFileName\n Give a file-name to save data needed", "File Name is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);//should be deleted
                FileName = openDialog2ChooseFile(_fileChooser, _initialDir);
            }
            if (result != DialogResult.Cancel)
            {
                #region save file via FileStream if user specified valid file
                try
                {
                    #region open file with write access
                    MessageBox.Show("File name (in CreateFile)=" + FileName);
                    //output = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    output = new FileStream(FileName, fileMode, FileAccess.Write);

                    if (Stream_Based == (int)(FileStreamBasedEnumNew.TEXT_BASED))
                        //fileWriter = new StreamWriter(output);//old one
                        fileWriter = new StreamWriter(output, System.Text.Encoding.BigEndianUnicode);
                    //https://twblog.hongjianching.com/2017/12/17/why-csharp-write-and-read-file-with-different-encoding-but-success/
                    else if (Stream_Based == (int)(FileStreamBasedEnumNew.BYTE_BASED))
                        writeFormatter = new BinaryFormatter();

                    FileNameOutput = FileName;
                    MessageBox.Show("File name=" + FileName);
                    #endregion open file with write access
                }
                #region handle exception if there is a problem opening the file
                catch (IOException ex)
                {
                    // notify user if file could not be opened
                    MessageBox.Show(ex.Message + " Error opening/writing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Environment.Exit(0);
                }
                #endregion handle exception if there is a problem opening the file
                #endregion save file via FileStream if user specified valid file
            }
            return output;
        }//end CreateFileStreamAndWriteAccess(string FileName, OpenFileDialog fileChooser)


        public OpenReadOrWriteWithCheck_Hua0045(bool readON, bool writeON, string inputFileName, string outputFileName, int _streamBased, FileMode _fileMode,
           OpenFileDialog _fileChooser, String _initialDir)//added 08June2021 
        {
            FileOutput_ON = writeON;
            FileInput_ON = readON;
            Stream_Based = _streamBased;

            FileNameOutput = outputFileName;
            FileNameInput = inputFileName;


            if (FileOutput_ON == true)
            {
                fileMode = _fileMode;
                CreateFileStreamAndWriteAccess(FileNameOutput, _fileChooser, _initialDir);
            }
            if (FileInput_ON == true)
            {
                getFileStreamAndReadAccess(ref FileNameInput);
            }
        }


    }//end class OpenReadOrWriteWithCheck
}//end namespace ClassLibrary_Huang0045.FileStreams
