using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoachingManagementSystem
{
    public class DatabaseCoachingInst
    {
        public enum Tables
        {
            Batch,
            Chapter,
            ChapterTracking,
            Class,
            GroupDiscussion,
            Lectures,
            MainTestTracking,
            ProblemSolvingTracking,
            Subject,
            Topic,
            TopicTracking,
            User,
            UserRole
        }
        // Contains constants
        public enum Batch
        {
            Batch_ID,
            BatchName,
            BatchDescription,
            Class_ID
        }

        public enum Chapter
        {
            Chapter_ID,
            Class_ID,
            Subject_ID,
            Chapter_Name,
            Chapter_Description
        }

        public enum ChapterTracking
        {
            ChapterTracking_ID,
            Chapter_ID,
            Batch_ID,
            GDDone,
            PSSDone,
            TestDone,
            NumericalTestDone,
            VerifiedBy_ID,
            Remarks
        }

        public enum Class
        {
            Class_id,
            ClassName,
            ClassDescription
        }

        public enum GroupDiscussion
        {
            GDSessionNumber_ID,
            DateOfGD,
            TeacherName_ID,
            StartTime,
            EndTime
        }

        public enum Lectures
        {
            Lecture_ID,
            DateOfLecture,
            StartTime,
            EndTime,
            BatchID,
            SubjectID,
            TeacherID,
            AttendanceTaken,
            SignOffBy_ID,
            DPTPreparedBy_ID,
            DPTFile,
            DPTDate,
            DPTTakenBy_ID,
            DPTCorrectedBy_ID,
            DPTResultDisplayed,
            DPTProblemSet
        }

        public enum MainTestTracking
        {
            TestPaperFileName,
            TestPaper_ID,
            PreparedBy_ID,
            ReviewedBy_ID,
            TestTakenBy_ID,
            CopyCorrector_ID,
            IsNumericalTest,
            InformedToStudents,
            DateOfTestPaper,
            CopyToCorrectorGivenOn,
            CopiesGivenOn,
            CopiesCollectedOn,
            ResultDisplayedOn,
        }

        public enum ProblemSolvingTracking
        {
            ProblemSSNumber_ID,
            ProblemSetGivenToTeacher,
            Admin_ID,
            DateOfPSS,
            TeacherName_ID
        }

        public enum Subject
        {
            Subject_ID,
            SubjectName,
            Class_ID,
            SubjectDescription
        }

        public enum Topic
        {
            Topic_ID,
            Chapter_ID,
            Topic_Name,
            Topic_Description
        }

        public enum TopicTracking
        {
            TopicTracking_ID,
            Topic_ID,
            Batch_ID,
            CoverPercentage,
            Lecture_ID        
        }

        public enum User
        {
            user_id,
            user_name,
            user_role_id,
            Address,
            Phone,
            email,
            password
        }

        public enum UserRole
        {
            User_Role_ID,
            UserRole,
            AccessControl
        }

        // Constains small util functions
    }

    public class utility {
        public static void AddDeleteAndEditButton(DataGridView dgv)
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Edit";
            col.Name = "Edit";
            dgv.Columns.Add(col);


            DataGridViewButtonColumn col2 = new DataGridViewButtonColumn();
            col2.UseColumnTextForButtonValue = true;
            col2.Text = "Delete";
            col2.Name = "Delete";
            dgv.Columns.Add(col2);
        }
    
    
    }
}
